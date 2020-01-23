namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ApplicationUsageControlTerminalAction : EmvElementVisitorBase
    {
        private ApplicationUsageControl auc;

        public override void Visit(ApplicationUsageControl item)
        {
            auc = item;
        }

        private TerminalCountryCode tcc;

        public override void Visit(TerminalCountryCode item)
        {
            tcc = item;
        }

        private IssuerCountryCode icc;

        public override void Visit(IssuerCountryCode item)
        {
            icc = item;
        }

        /// <summary>
        /// Indicates whether the requested service is allowed based on the <see cref="ApplicationUsageControl"/>,
        /// <see cref="TerminalCountryCode"/> and <see cref="IssuerCountryCode"/> EMV values.
        /// </summary>
        /// <returns></returns>
        public ApplicationUsageControlTerminalActionResult RequestedServiceAllowed()
        {
            if (auc == null)
            {
                return ApplicationUsageControlTerminalActionResult.Allowed;
            }

            if ((auc.Results & ApplicationUsageControlMeaning.ValidAtTerminalsOtherThanATMs) 
                != ApplicationUsageControlMeaning.ValidAtTerminalsOtherThanATMs)
            {
                return ApplicationUsageControlTerminalActionResult.NotValidAtTerminalsOtherThanATMs;
            }

            if (tcc == null || icc == null)
            {
                return ApplicationUsageControlTerminalActionResult.Allowed;
            }

            if (!tcc.Currency.HasValue || !icc.Currency.HasValue)
            {
                return ApplicationUsageControlTerminalActionResult.Allowed;
            }

            if (tcc.Currency.Value == icc.Currency.Value)
            {
                if ((auc.Results & ApplicationUsageControlMeaning.ValidForDomesticGoods) ==
                    ApplicationUsageControlMeaning.ValidForDomesticGoods)
                {
                    return ApplicationUsageControlTerminalActionResult.Allowed;
                }

                return ((auc.Results & ApplicationUsageControlMeaning.ValidForDomesticServices) ==
                        ApplicationUsageControlMeaning.ValidForDomesticServices)
                           ? ApplicationUsageControlTerminalActionResult.Allowed
                           : ApplicationUsageControlTerminalActionResult.NotValidForDomestic;
            }

            if ((auc.Results & ApplicationUsageControlMeaning.ValidForInternationalGoods) ==
                        ApplicationUsageControlMeaning.ValidForInternationalGoods)
            {
                return ApplicationUsageControlTerminalActionResult.Allowed;
            }

            return ((auc.Results & ApplicationUsageControlMeaning.ValidForInternationalServices) ==
                    ApplicationUsageControlMeaning.ValidForInternationalServices)
                       ? ApplicationUsageControlTerminalActionResult.Allowed
                       : ApplicationUsageControlTerminalActionResult.NotValidForInternational;
        }
    }
}
