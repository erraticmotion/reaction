namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// Responsible for determining whether the card is valid for domestic goods and services
    /// </summary>
    public sealed class ValidForDomesticGoodsAndServices : EmvElementVisitorBase
    {
        private bool validForDomesticGoods;

        public override void Visit(ApplicationUsageControl item)
        {
            OnDiagnostic("Application Usage Control");
            OnDiagnostic(item.ToString());
            if (item.Value[0] != 0x57)
            {
                OnDiagnostic("AUC -> Valid for domestic goods and services");
                validForDomesticGoods = true;
            }
            else
            {
                OnDiagnostic("AUC -> Not valid for domestic goods and services");
                validForDomesticGoods = false;
            }
        }

        private bool frenchIssuedCard;

        public override void Visit(IssuerCountryCode item)
        {
            OnDiagnostic("Issuer County {0}", item.Country);
            frenchIssuedCard = (item.Country == Country.France);
            OnDiagnostic("ICC -> Is French card? {0}", frenchIssuedCard);
        }

        /// <summary>
        /// Indicates whether the card is valid for domestic goods and services.
        /// </summary>
        /// <value><c>true</c> to indicate if the card is valid for domestic goods and services;otherwise <c>false</c></value>
        public bool IsValid { get { return !(!validForDomesticGoods && frenchIssuedCard); } }
    }
}
