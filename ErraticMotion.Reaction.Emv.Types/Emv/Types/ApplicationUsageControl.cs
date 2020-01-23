namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Collections;
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// The Application Usage Control indicates restrictions limiting the application geographically or to certain types of transactions. 
    /// </summary>
    public sealed class ApplicationUsageControl : EmvElement
    {
        internal static ApplicationUsageControl Create(ApplicationUsageControlMeaning meaning)
        {
            var byte1 = new BitArray(8, false);

            if ((meaning & ApplicationUsageControlMeaning.ValidForDomesticCashTransactions)
                == ApplicationUsageControlMeaning.ValidForDomesticCashTransactions)
            {
                byte1[7] = true;
            }

            if ((meaning & ApplicationUsageControlMeaning.ValidForInternationalCashTransactions)
                == ApplicationUsageControlMeaning.ValidForInternationalCashTransactions)
            {
                byte1[6] = true;
            }

            if ((meaning & ApplicationUsageControlMeaning.ValidForDomesticGoods)
                == ApplicationUsageControlMeaning.ValidForDomesticGoods)
            {
                byte1[5] = true;
            }

            if ((meaning & ApplicationUsageControlMeaning.ValidForInternationalGoods)
                == ApplicationUsageControlMeaning.ValidForInternationalGoods)
            {
                byte1[4] = true;
            }

            if ((meaning & ApplicationUsageControlMeaning.ValidForDomesticServices)
                == ApplicationUsageControlMeaning.ValidForDomesticServices)
            {
                byte1[3] = true;
            }

            if ((meaning & ApplicationUsageControlMeaning.ValidForInternationalServices)
                == ApplicationUsageControlMeaning.ValidForInternationalServices)
            {
                byte1[2] = true;
            }

            if ((meaning & ApplicationUsageControlMeaning.ValidAtATMs)
                == ApplicationUsageControlMeaning.ValidAtATMs)
            {
                byte1[1] = true;
            }

            if ((meaning & ApplicationUsageControlMeaning.ValidAtTerminalsOtherThanATMs)
                == ApplicationUsageControlMeaning.ValidAtTerminalsOtherThanATMs)
            {
                byte1[0] = true;
            }

            var byte2 = new BitArray(8, false);

            if ((meaning & ApplicationUsageControlMeaning.DomesticCashbackAllowed)
                == ApplicationUsageControlMeaning.DomesticCashbackAllowed)
            {
                byte2[7] = true;
            }

            if ((meaning & ApplicationUsageControlMeaning.InternationalCashbackAllowed)
                == ApplicationUsageControlMeaning.InternationalCashbackAllowed)
            {
                byte2[6] = true;
            }

            return new ApplicationUsageControl(byte1.ToByte(), byte2.ToByte());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUsageControl"/> class.
        /// </summary>
        /// <param name="byte1">The byte1.</param>
        /// <param name="byte2">The byte2.</param>
        public ApplicationUsageControl(byte byte1, byte byte2)
            : this(new[] { byte1, byte2 })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUsageControl"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ApplicationUsageControl(byte[] value)
            : base(TagLengthValueType.ApplicationUsageControl, value)
        {
            if (value.Length != 2)
            {
                throw new ArgumentOutOfRangeException("value", "AIP values was not 2 in length");
            }

            var bits = new BitArray(new[] { value[0] });
            if (bits[7]) Results |= ApplicationUsageControlMeaning.ValidForDomesticCashTransactions;
            if (bits[6]) Results |= ApplicationUsageControlMeaning.ValidForInternationalCashTransactions;
            if (bits[5]) Results |= ApplicationUsageControlMeaning.ValidForDomesticGoods;
            if (bits[4]) Results |= ApplicationUsageControlMeaning.ValidForInternationalGoods;
            if (bits[3]) Results |= ApplicationUsageControlMeaning.ValidForDomesticServices;
            if (bits[2]) Results |= ApplicationUsageControlMeaning.ValidForInternationalServices;
            if (bits[1]) Results |= ApplicationUsageControlMeaning.ValidAtATMs;
            if (bits[0]) Results |= ApplicationUsageControlMeaning.ValidAtTerminalsOtherThanATMs;

            bits = new BitArray(new[] { value[1] });
            if (bits[7]) Results |= ApplicationUsageControlMeaning.DomesticCashbackAllowed;
            if (bits[6]) Results |= ApplicationUsageControlMeaning.InternationalCashbackAllowed;
        }

        /// <summary>
        /// Gets the results of the AUC
        /// </summary>
        public ApplicationUsageControlMeaning Results { get; private set; }

        #region Overrides of EmvElement

        /// <summary>
        /// 
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(IEmvElementVisitor visitor)
        {
            visitor.Visit(this);
        }

        #endregion

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            Func<string, object, string> f = (n, o) => string.Format(CultureInfo.InvariantCulture,
                "{0,40}: " + (o is byte ? "0x{1:X2}" : "{1}"), n, o);

            var builder = new StringBuilder();
            builder.AppendLine(string.Format(CultureInfo.InvariantCulture, "{0}", GetType().Name));
            builder.AppendLine(f("AUC[0]", Value[0]));
            builder.AppendLine(f("AUC[1]", Value[0]));
            Results.ToString().Split(',').ForEach(x => builder.AppendLine(f("AUC -> ", x.Trim())));
            return builder.ToString();
        }
    }
}
