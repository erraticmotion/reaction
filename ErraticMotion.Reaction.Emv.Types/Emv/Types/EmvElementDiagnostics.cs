namespace Servebase.Pceft.Ped.Emv
{
    internal class EmvElementDiagnostics : IEmvElementDiagnostics
    {
        private readonly IEmvElement value;

        public EmvElementDiagnostics(IEmvElement value)
        {
            this.value = value;
        }

        public string InClear 
        {
            get
            {
                const string format = "{0,33}: {1}";
                return string.Format(format, value.Tag, value.ReadLanguage().AsString(false));
            }
        }
    }
}
