namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// An issuer may provide command scripts to be delivered to the ICC by the terminal to 
    /// perform functions that are not necessarily relevant to the current transaction but are 
    /// important for the continued functioning of the application in the ICC. Multiple scripts 
    /// may be provided with an authorisation response, and each may contain any number 
    /// of Issuer Script Commands. Script processing is provided to allow for functions that 
    /// are outside the scope of this specification but are nonetheless necessary.19 A script 
    /// may contain Issuer Script Commands not known to the terminal, but the terminal shall 
    /// deliver each command to the ICC individually according to this specification.
    /// </summary>
    /// <remarks>
    /// Two separate script tags are available for use by the issuer. Issuer scripts with tag '71' shall be 
    /// processed prior to issuing the final GENERATE AC command. Issuer scripts with tag '72' shall be 
    /// processed after issuing the final GENERATE AC command.
    /// </remarks>
    public sealed class IssuerToCardScriptProcessor : IIssuerScripts
    {
        private readonly MemoryStream stream;
        private readonly List<IssuerScriptCommand> issuerScriptCommands = new List<IssuerScriptCommand>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerToCardScriptProcessor"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public IssuerToCardScriptProcessor(byte[] value)
        {
            stream = new MemoryStream(value);
            ScriptId = (byte)stream.ReadByte();
            var l = stream.ReadByte();

            var pos = stream.Position;
            var guff = new byte[2];
            stream.Read(guff, 0, 2);

            byte[] buffer;
            if (guff[0] == 0x9f && guff[1] == 0x18)
            {
                var len = stream.ReadByte();
                if (len == 0)
                {
                    buffer = new byte[l - 3];
                    stream.Read(buffer, 0, buffer.Length);
                }
                else
                {
                    stream.Position += len;
                    buffer = new byte[l - (3 + len)];
                    stream.Read(buffer, 0, buffer.Length);
                }
            }
            else
            {
                buffer = new byte[l];
                stream.Position = pos;
                stream.Read(buffer, 0, buffer.Length);
            }

            //buffer.ForEach(x => Console.Write(x.ToString("X2")));
            //Console.WriteLine();

            ScriptData = buffer;
            Parse(new MemoryStream(ScriptData));
            NumberOfScripts = Scripts.Count();
        }

        private void Parse(MemoryStream data)
        {
            var moreGuff = data.ToArray();
            if (moreGuff[0] == 0x9f && moreGuff[1] == 0x18)
            {
                var len = moreGuff[2];
                var buffer = new byte[moreGuff.Length - (3 + len)];
                //Console.WriteLine("buffer length: {0}", buffer.Length);
                //Console.WriteLine("data length: {0}", data.Length);
                //Console.WriteLine("data position: {0}", data.Position);
                data.Position = 3 + len;
                data.Read(buffer, 0, buffer.Length);
                Parse(new MemoryStream(buffer));
            }

            //Console.WriteLine("data length: {0}", data.Length);
            var el = data.ReadByte();
            if (el == -1)
            {
                return;
            }

            //Console.WriteLine("el: {0}", el.ToString("X2"));
            var l = data.ReadByte();
            //Console.WriteLine("l: {0}",l.ToString("X2"));
            var b = new byte[l];
            data.Read(b, 0, l);
            //Console.Write("data: ");
            //b.ForEach(x => Console.Write(x.ToString("X2")));
            //Console.WriteLine();

            issuerScriptCommands.Add(new IssuerScriptCommand((TagLengthValueType)el, b));
            var left = (int)data.Length - (l + 2);
            //Console.WriteLine("left: {0}", left);
            if (left <= 0)
            {
                return;
            }

            var next = new byte[left];
            data.Read(next, 0, left);
            Parse(new MemoryStream(next));
        }

        /// <summary>
        /// 
        /// </summary>
        public byte ScriptId { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public bool BeforeSecondGenerate
        {
            get
            {
                return ScriptId == 0x71;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<IssuerScriptCommand> Scripts { get { return issuerScriptCommands; } }

        /// <summary>
        /// 
        /// </summary>
        public int NumberOfScripts { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public byte[] ScriptData { get; private set; }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            Func<string, object, string> f = (n, o) => string.Format(CultureInfo.InvariantCulture, "{0,45}: {1}", n, o);
            var builder = new StringBuilder();
            builder.AppendLine(f("Script Id", ScriptId.ToString("X2")));
            builder.AppendLine(f("Before 2nd generate", BeforeSecondGenerate));
            builder.AppendLine(f("Number of Scripts", NumberOfScripts));
            Scripts.ForIndex((i, x) => builder.AppendLine(f("Script " + i, x)));
            return builder.ToString();
        }
    }
}
