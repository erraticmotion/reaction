namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// ISO 3166-1 numeric (or numeric-3) codes are three-digit country codes defined in ISO 3166-1, part of 
    /// the ISO 3166 standard published by the International Organization for Standardization (ISO), to represent 
    /// countries, dependent territories, and special areas of geographical interest. 
    /// </summary>
    public sealed class Country : IEquatable<Country>
    {
        #region Statc Members

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Afghanistan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Albania;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Antarctica;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Algeria;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country AmericanSamoa;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Andorra;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Angola;

        /// <summary>
        /// 
        /// </summary>
        public static Country AntiguaAndBarbuda;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Azerbaijan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Argentina;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Australia;

        /// <summary>
        /// ISO 3166-1 numeric 40
        /// </summary>
        public static readonly Country Austria;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Bahamas;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Bahrain;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Bangladesh;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Armenia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Barbados;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Belgium;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Bermuda;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Bhutan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Bolivia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country BosniaAndHerzegovina;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Botswana;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country BouvetIsland;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Brazil;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Belize;

        /// <summary>
        /// 
        /// </summary>
        public static Country BritishIndianOceanTerritory;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SolomonIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country BritishVirginIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country BruneiDarussalam;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Bulgaria;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Myanmar;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Burundi;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Belarus;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Cambodia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Cameroon;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Canada;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country CapeVerde;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country CaymanIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country CentralAfricanRepublic;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SriLanka;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Chad;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Chile;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country China;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Taiwan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country ChristmasIsland;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country CocosIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Colombia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Comoros;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Mayotte;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Congo;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country CongoDemocraticRepublic;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country CookIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country CostaRica;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Croatia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Cuba;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Cyprus;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country CzechRepublic;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Benin;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Denmark;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Dominica;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country DominicanRepublic;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Ecuador;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country ElSalvador;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country EquatorialGuinea;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Ethiopia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Eritrea;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Estonia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country FaroeIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country FalklandIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SouthGeorgiaAndTheSouthSandwichIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Fiji;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Finland;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country AlandIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country France;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country FrenchGuiana;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country FrenchPolynesia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country FrenchSouthernTerritories;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Djibouti;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Gabon;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Georgia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Gambia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country PalestinianTerritory;

        /// <summary>
        /// ISO 3166-1 numeric 276
        /// </summary>
        public static readonly Country Germany;

        /// <summary>
        /// East Germany used numeric code 278. Since then, the unified Germany has used numeric code 276, while keeping the alphabetic codes for West Germany.
        /// </summary>
        /// <remarks>
        /// Required for Elavon compatibility. AF PIN Pads have been configured to use 280 West Germany instead of 276 Germany
        /// </remarks>
        [Obsolete] 
        public static readonly Country EastGermany;

        /// <summary>
        /// West Germany used numeric code 280. Since then, the unified Germany has used numeric code 276, while keeping the alphabetic codes for West Germany.
        /// </summary>
        /// <remarks>
        /// Required for Elavon compatibility. AF PIN Pads have been configured to use 280 West Germany instead of 276 Germany
        /// </remarks>
        [Obsolete]
        public static readonly Country WestGermany;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Ghana;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Gibraltar;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Kiribati;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Greece;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Greenland;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Grenada;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Guadeloupe;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Guam;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Guatemala;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Guinea;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Guyana;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Haiti;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country HeardIslandAndMcDonaldIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country VaticanCityState;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Honduras;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country HongKong;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Hungary;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Iceland;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country India;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Indonesia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Iran;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Iraq;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Ireland;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Israel;

        /// <summary>
        /// ISO 3166-1 numeric 380
        /// </summary>
        public static readonly Country Italy;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country IvoryCote;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Jamaica;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Japan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Kazakhstan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Jordan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Kenya;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country KoreaDemocraticPeoplesRepublic;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country KoreaRepublic;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Kuwait;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Kyrgyzstan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Lao;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Lebanon;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Lesotho;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Latvia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Liberia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country LibyanArabJamahiriya;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Liechtenstein;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Lithuania;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Luxembourg;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Macao;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Madagascar;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Malawi;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Malaysia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Maldives;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Mali;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Malta;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Martinique;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Mauritania;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Mauritius;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Mexico;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Monaco;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Mongolia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Moldova;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Montenegro;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Montserrat;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Morocco;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Mozambique;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Oman;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Namibia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Nauru;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Nepal;

        /// <summary>
        /// ISO 3166-1 numeric 528
        /// </summary>
        public static readonly Country Netherlands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Curaçao;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Aruba;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SintMaarten;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country BonaireSaintEustatiusAndSaba;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country NewCaledonia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Vanuatu;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country NewZealand;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Nicaragua;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Niger;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Nigeria;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Niue;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country NorfolkIsland;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Norway;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country NorthernMarianaIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country UnitedStatesMinorOutlyingIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Micronesia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country MarshallIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Palau;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Pakistan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Panama;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country PapuaNewGuinea;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Paraguay;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Peru;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Philippines;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Pitcairn;

        /// <summary>
        /// ISO 3166-1 numeric 616
        /// </summary>
        public static readonly Country Poland;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Portugal;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country GuineaBissau;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country TimorLeste;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country PuertoRico;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Qatar;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Reunion;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Romania;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country RussianFederation;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Rwanda;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SaintBarthélemy;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SaintHelenaAscensionAndTristanDaCunha;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SaintKittsAndNevis;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Anguilla;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SaintLucia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SaintMartin;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SaintPierreAndMiquelon;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SaintVincentAndGrenadines;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SanMarino;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SaoTomeAndPrincipe;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SaudiArabia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Senegal;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Serbia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Seychelles;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SierraLeone;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Singapore;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Slovakia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country VietNam;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Slovenia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Somalia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SouthAfrica;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Zimbabwe;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Spain;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country WesternSahara;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Sudan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Suriname;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SvalbardAndJanMayen;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Swaziland;

        /// <summary>
        /// ISO 3166-1 numeric 752
        /// </summary>
        public static readonly Country Sweden;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Switzerland;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country SyrianArabRepublic;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Tajikistan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Thailand;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Togo;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Tokelau;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Tonga;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country TrinidadAndTobago;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country UnitedArabEmirates;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Tunisia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Turkey;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Turkmenistan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country TurksAndCaicosIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Tuvalu;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Uganda;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Ukraine;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Macedonia;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Egypt;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country UnitedKingdom;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Guernsey;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Jersey;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country IsleOfMan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Tanzania;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country UnitedStates;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country VirginIslands;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country BurkinaFaso;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Uruguay;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Uzbekistan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Venezuela;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country WallisAndFutuna;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Samoa;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Yemen;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Country Zambia;

        #endregion

        #region Static Ctor

        private static readonly Dictionary<Int32, CountryTableEntry> Countries =
            new Dictionary<Int32, CountryTableEntry>();

        /// <summary>
        /// Initializes the <see cref="Country"/> class.
        /// </summary>
        static Country()
        {
            Countries[4] = new CountryTableEntry(4, "Afghanistan", "AFG");
            Countries[8] = new CountryTableEntry(8, "Albania", "ALB");
            Countries[10] = new CountryTableEntry(10, "Antarctica", "ATA");
            Countries[12] = new CountryTableEntry(12, "Algeria", "DZA"); 
            Countries[16] = new CountryTableEntry(16, "American Samoa", "ASM");
            Countries[20] = new CountryTableEntry(20, "Andorra", "AND");
            Countries[24] = new CountryTableEntry(24, "Angola", "AGO");
            Countries[28] = new CountryTableEntry(28, "Antigua and Barbuda", "ATG");
            Countries[31] = new CountryTableEntry(31, "Azerbaijan", "AZE");
            Countries[32] = new CountryTableEntry(32, "Argentina", "ARG");
            Countries[36] = new CountryTableEntry(36, "Australia", "AUS");
            Countries[40] = new CountryTableEntry(40, "Austria", "AUT");
            Countries[44] = new CountryTableEntry(44, "Bahamas", "BHS");
            Countries[48] = new CountryTableEntry(48, "Bahrain", "BHR");
            Countries[50] = new CountryTableEntry(50, "Bangladesh", "BGD");
            Countries[51] = new CountryTableEntry(51, "Armenia", "ARM");
            Countries[52] = new CountryTableEntry(52, "Barbados", "BRB");
            Countries[56] = new CountryTableEntry(56, "Belgium", "BEL");
            Countries[60] = new CountryTableEntry(60, "Bermuda", "BMU");
            Countries[64] = new CountryTableEntry(64, "Bhutan", "BTN");
            Countries[68] = new CountryTableEntry(68, "Bolivia, Plurinational State of", "BOL");
            Countries[70] = new CountryTableEntry(70, "Bosnia and Herzegovina", "BIH");
            Countries[72] = new CountryTableEntry(72, "Botswana", "BWA");
            Countries[74] = new CountryTableEntry(74, "Bouvet Island", "BVT");
            Countries[76] = new CountryTableEntry(76, "Brazil", "BRA");
            Countries[84] = new CountryTableEntry(84, "Belize", "BLZ");
            Countries[86] = new CountryTableEntry(86, "British Indian Ocean Territory", "IOT"); 
            Countries[90] = new CountryTableEntry(90, "Solomon Islands", "SLB"); 
            Countries[92] = new CountryTableEntry(92, "Virgin Islands, British", "VGB"); 
            Countries[96] = new CountryTableEntry(96, "Brunei Darussalam", "BRN");
            Countries[100] = new CountryTableEntry(100, "Bulgaria", "BGR");
            Countries[104] = new CountryTableEntry(104, "Myanmar", "MMR"); 
            Countries[108] = new CountryTableEntry(108, "Burundi", "BDI");
            Countries[112] = new CountryTableEntry(112, "Belarus", "BLR");
            Countries[116] = new CountryTableEntry(116, "Cambodia", "KHM"); 
            Countries[120] = new CountryTableEntry(120, "Cameroon", "CMR");
            Countries[124] = new CountryTableEntry(124, "Canada", "CAN");
            Countries[132] = new CountryTableEntry(132, "Cape Verde", "CPV");
            Countries[136] = new CountryTableEntry(136, "Cayman Islands", "CYM");
            Countries[140] = new CountryTableEntry(140, "Central African Republic", "CAF");
            Countries[144] = new CountryTableEntry(144, "Sri Lanka", "LKA"); 
            Countries[148] = new CountryTableEntry(148, "Chad", "TCD"); 
            Countries[152] = new CountryTableEntry(152, "Chile", "CHL");
            Countries[156] = new CountryTableEntry(156, "China", "CHN");
            Countries[158] = new CountryTableEntry(158, "Taiwan, Province of China", "TWN"); 
            Countries[162] = new CountryTableEntry(162, "Christmas Island", "CXR");
            Countries[166] = new CountryTableEntry(166, "Cocos (Keeling) Islands", "CCK"); 
            Countries[170] = new CountryTableEntry(170, "Colombia", "COL");
            Countries[174] = new CountryTableEntry(174, "Comoros", "COM");
            Countries[175] = new CountryTableEntry(175, "Mayotte", "MYT"); 
            Countries[178] = new CountryTableEntry(178, "Congo", "COG");
            Countries[180] = new CountryTableEntry(180, "Congo, the Democratic Republic of the", "COD");
            Countries[184] = new CountryTableEntry(184, "Cook Islands", "COK");
            Countries[188] = new CountryTableEntry(188, "Costa Rica", "CRI");
            Countries[191] = new CountryTableEntry(191, "Croatia", "HRV"); 
            Countries[192] = new CountryTableEntry(192, "Cuba", "CUB");
            Countries[196] = new CountryTableEntry(196, "Cyprus", "CYP");
            Countries[203] = new CountryTableEntry(203, "Czech Republic", "CZE");
            Countries[204] = new CountryTableEntry(204, "Benin", "BEN");
            Countries[208] = new CountryTableEntry(208, "Denmark", "DNK");
            Countries[212] = new CountryTableEntry(212, "Dominica", "DMA");
            Countries[214] = new CountryTableEntry(214, "Dominican Republic", "DOM");
            Countries[218] = new CountryTableEntry(218, "Ecuador", "ECU");
            Countries[222] = new CountryTableEntry(222, "El Salvador", "SLV"); 
            Countries[226] = new CountryTableEntry(226, "Equatorial Guinea", "GNQ"); 
            Countries[231] = new CountryTableEntry(231, "Ethiopia", "ETH");
            Countries[232] = new CountryTableEntry(232, "Eritrea", "ERI");
            Countries[233] = new CountryTableEntry(233, "Estonia", "EST");
            Countries[234] = new CountryTableEntry(234, "Faroe Islands", "FRO");
            Countries[238] = new CountryTableEntry(238, "Falkland Islands", "FLK"); 
            Countries[239] = new CountryTableEntry(239, "South Georgia and the South Sandwich Islands", "SGS"); 
            Countries[242] = new CountryTableEntry(242, "Fiji", "FJI");
            Countries[246] = new CountryTableEntry(246, "Finland", "FIN");
            Countries[248] = new CountryTableEntry(248, "Aland Islands !Åland Islands", "ALA");
            Countries[250] = new CountryTableEntry(250, "France", "FRA");
            Countries[254] = new CountryTableEntry(254, "French Guiana", "GUF"); 
            Countries[258] = new CountryTableEntry(258, "French Polynesia", "PYF"); 
            Countries[260] = new CountryTableEntry(260, "French Southern Territories", "ATF"); 
            Countries[262] = new CountryTableEntry(262, "Djibouti", "DJI");
            Countries[266] = new CountryTableEntry(266, "Gabon", "GAB");
            Countries[268] = new CountryTableEntry(268, "Georgia", "GEO");
            Countries[270] = new CountryTableEntry(270, "Gambia", "GMB");
            Countries[275] = new CountryTableEntry(275, "Palestinian Territory, Occupied", "PSE"); 
            Countries[276] = new CountryTableEntry(276, "Germany", "DEU"); 
            Countries[278] = new CountryTableEntry(278, "German Democratic Republic (East Germany)", "DEU"); //Explicitly set this as Germany
            Countries[280] = new CountryTableEntry(280, "Federal Republic of Germany (West Germany)", "DEU"); //Explicitly set this as Germany
            Countries[288] = new CountryTableEntry(288, "Ghana", "GHA");
            Countries[292] = new CountryTableEntry(292, "Gibraltar", "GIB");
            Countries[296] = new CountryTableEntry(296, "Kiribati", "KIR"); 
            Countries[300] = new CountryTableEntry(300, "Greece", "GRC");
            Countries[304] = new CountryTableEntry(304, "Greenland", "GRL");
            Countries[308] = new CountryTableEntry(308, "Grenada", "GRD");
            Countries[312] = new CountryTableEntry(312, "Guadeloupe", "GLP");
            Countries[316] = new CountryTableEntry(316, "Guam", "GUM");
            Countries[320] = new CountryTableEntry(320, "Guatemala", "GTM");
            Countries[324] = new CountryTableEntry(324, "Guinea", "GIN");
            Countries[328] = new CountryTableEntry(328, "Guyana", "GUY");
            Countries[332] = new CountryTableEntry(332, "Haiti", "HTI");
            Countries[334] = new CountryTableEntry(334, "Heard Island and McDonald Islands", "HMD");
            Countries[336] = new CountryTableEntry(336, "Holy See (Vatican City State)", "VAT"); 
            Countries[340] = new CountryTableEntry(340, "Honduras", "HND");
            Countries[344] = new CountryTableEntry(344, "Hong Kong", "HKG");
            Countries[348] = new CountryTableEntry(348, "Hungary", "HUN");
            Countries[352] = new CountryTableEntry(352, "Iceland", "ISL");
            Countries[356] = new CountryTableEntry(356, "India", "IND");
            Countries[360] = new CountryTableEntry(360, "Indonesia", "IDN");
            Countries[364] = new CountryTableEntry(364, "Iran, Islamic Republic of", "IRN");
            Countries[368] = new CountryTableEntry(368, "Iraq", "IRQ");
            Countries[372] = new CountryTableEntry(372, "Ireland", "IRL");
            Countries[376] = new CountryTableEntry(376, "Israel", "ISR");
            Countries[380] = new CountryTableEntry(380, "Italy", "ITA");
            Countries[384] = new CountryTableEntry(384, "Cote d'Ivoire !Côte d'Ivoire", "CIV"); 
            Countries[388] = new CountryTableEntry(388, "Jamaica", "JAM");
            Countries[392] = new CountryTableEntry(392, "Japan", "JPN");
            Countries[398] = new CountryTableEntry(398, "Kazakhstan", "KAZ");
            Countries[400] = new CountryTableEntry(400, "Jordan", "JOR");
            Countries[404] = new CountryTableEntry(404, "Kenya", "KEN");
            Countries[408] = new CountryTableEntry(408, "Korea, Democratic People's Republic of", "PRK"); 
            Countries[410] = new CountryTableEntry(410, "Korea, Republic of", "KOR");
            Countries[414] = new CountryTableEntry(414, "Kuwait", "KWT");
            Countries[417] = new CountryTableEntry(417, "Kyrgyzstan", "KGZ");
            Countries[418] = new CountryTableEntry(418, "Lao People's Democratic Republic", "LAO");
            Countries[422] = new CountryTableEntry(422, "Lebanon", "LBN");
            Countries[426] = new CountryTableEntry(426, "Lesotho", "LSO");
            Countries[428] = new CountryTableEntry(428, "Latvia", "LVA");
            Countries[430] = new CountryTableEntry(430, "Liberia", "LBR");
            Countries[434] = new CountryTableEntry(434, "Libyan Arab Jamahiriya", "LBY");
            Countries[438] = new CountryTableEntry(438, "Liechtenstein", "LIE");
            Countries[440] = new CountryTableEntry(440, "Lithuania", "LTU");
            Countries[442] = new CountryTableEntry(442, "Luxembourg", "LUX");
            Countries[446] = new CountryTableEntry(446, "Macao", "MAC");
            Countries[450] = new CountryTableEntry(450, "Madagascar", "MDG");
            Countries[454] = new CountryTableEntry(454, "Malawi", "MWI");
            Countries[458] = new CountryTableEntry(458, "Malaysia", "MYS");
            Countries[462] = new CountryTableEntry(462, "Maldives", "MDV");
            Countries[466] = new CountryTableEntry(466, "Mali", "MLI");
            Countries[470] = new CountryTableEntry(470, "Malta", "MLT");
            Countries[474] = new CountryTableEntry(474, "Martinique", "MTQ");
            Countries[478] = new CountryTableEntry(478, "Mauritania", "MRT");
            Countries[480] = new CountryTableEntry(480, "Mauritius", "MUS");
            Countries[484] = new CountryTableEntry(484, "Mexico", "MEX");
            Countries[492] = new CountryTableEntry(492, "Monaco", "MCO");
            Countries[496] = new CountryTableEntry(496, "Mongolia", "MNG");
            Countries[498] = new CountryTableEntry(498, "Moldova, Republic of", "MDA");
            Countries[499] = new CountryTableEntry(499, "Montenegro", "MNE");
            Countries[500] = new CountryTableEntry(500, "Montserrat", "MSR");
            Countries[504] = new CountryTableEntry(504, "Morocco", "MAR");
            Countries[508] = new CountryTableEntry(508, "Mozambique", "MOZ");
            Countries[512] = new CountryTableEntry(512, "Oman", "OMN"); 
            Countries[516] = new CountryTableEntry(516, "Namibia", "NAM");
            Countries[520] = new CountryTableEntry(520, "Nauru", "NRU");
            Countries[524] = new CountryTableEntry(524, "Nepal", "NPL");
            Countries[528] = new CountryTableEntry(528, "Netherlands", "NLD");
            Countries[531] = new CountryTableEntry(531, "Curaçao", "CUW");
            Countries[533] = new CountryTableEntry(533, "Aruba", "ABW");
            Countries[534] = new CountryTableEntry(534, "Sint Maarten (Dutch part)", "SXM"); 
            Countries[535] = new CountryTableEntry(535, "Bonaire, Saint Eustatius and Saba", "BES");
            Countries[540] = new CountryTableEntry(540, "New Caledonia", "NCL"); 
            Countries[548] = new CountryTableEntry(548, "Vanuatu", "VUT");
            Countries[554] = new CountryTableEntry(554, "New Zealand", "NZL");
            Countries[558] = new CountryTableEntry(558, "Nicaragua", "NIC");
            Countries[562] = new CountryTableEntry(562, "Niger", "NER");
            Countries[566] = new CountryTableEntry(566, "Nigeria", "NGA");
            Countries[570] = new CountryTableEntry(570, "Niue", "NIU");
            Countries[574] = new CountryTableEntry(574, "Norfolk Island", "NFK");
            Countries[578] = new CountryTableEntry(578, "Norway", "NOR");
            Countries[580] = new CountryTableEntry(580, "Northern Mariana Islands", "MNP");
            Countries[581] = new CountryTableEntry(581, "United States Minor Outlying Islands", "UMI"); 
            Countries[583] = new CountryTableEntry(583, "Micronesia, Federated States of", "FSM"); 
            Countries[584] = new CountryTableEntry(584, "Marshall Islands", "MHL");
            Countries[585] = new CountryTableEntry(585, "Palau", "PLW");
            Countries[586] = new CountryTableEntry(586, "Pakistan", "PAK");
            Countries[591] = new CountryTableEntry(591, "Panama", "PAN");
            Countries[598] = new CountryTableEntry(598, "Papua New Guinea", "PNG");
            Countries[600] = new CountryTableEntry(600, "Paraguay", "PRY");
            Countries[604] = new CountryTableEntry(604, "Peru", "PER");
            Countries[608] = new CountryTableEntry(608, "Philippines", "PHL");
            Countries[612] = new CountryTableEntry(612, "Pitcairn", "PCN");
            Countries[616] = new CountryTableEntry(616, "Poland", "POL");
            Countries[620] = new CountryTableEntry(620, "Portugal", "PRT");
            Countries[624] = new CountryTableEntry(624, "Guinea-Bissau", "GNB"); 
            Countries[626] = new CountryTableEntry(626, "Timor-Leste", "TLS");
            Countries[630] = new CountryTableEntry(630, "Puerto Rico", "PRI");
            Countries[634] = new CountryTableEntry(634, "Qatar", "QAT");
            Countries[638] = new CountryTableEntry(638, "Reunion !Réunion", "REU");
            Countries[642] = new CountryTableEntry(642, "Romania", "ROU");
            Countries[643] = new CountryTableEntry(643, "Russian Federation", "RUS");
            Countries[646] = new CountryTableEntry(646, "Rwanda", "RWA");
            Countries[652] = new CountryTableEntry(652, "Saint Barthélemy", "BLM"); 
            Countries[654] = new CountryTableEntry(654, "Saint Helena, Ascension and Tristan da Cunha", "SHN");
            Countries[659] = new CountryTableEntry(659, "Saint Kitts and Nevis", "KNA"); 
            Countries[660] = new CountryTableEntry(660, "Anguilla", "AIA");
            Countries[662] = new CountryTableEntry(662, "Saint Lucia", "LCA"); 
            Countries[663] = new CountryTableEntry(663, "Saint Martin (French part)", "MAF"); 
            Countries[666] = new CountryTableEntry(666, "Saint Pierre and Miquelon", "SPM");
            Countries[670] = new CountryTableEntry(670, "Saint Vincent and the Grenadines", "VCT"); 
            Countries[674] = new CountryTableEntry(674, "San Marino", "SMR");
            Countries[678] = new CountryTableEntry(678, "Sao Tome and Principe", "STP");
            Countries[682] = new CountryTableEntry(682, "Saudi Arabia", "SAU");
            Countries[686] = new CountryTableEntry(686, "Senegal", "SEN");
            Countries[688] = new CountryTableEntry(688, "Serbia", "SRB");
            Countries[690] = new CountryTableEntry(690, "Seychelles", "SYC");
            Countries[694] = new CountryTableEntry(694, "Sierra Leone", "SLE");
            Countries[702] = new CountryTableEntry(702, "Singapore", "SGP");
            Countries[703] = new CountryTableEntry(703, "Slovakia", "SVK");
            Countries[704] = new CountryTableEntry(704, "Viet Nam", "VNM");
            Countries[705] = new CountryTableEntry(705, "Slovenia", "SVN");
            Countries[706] = new CountryTableEntry(706, "Somalia", "SOM");
            Countries[710] = new CountryTableEntry(710, "South Africa", "ZAF");
            Countries[716] = new CountryTableEntry(716, "Zimbabwe", "ZWE");
            Countries[724] = new CountryTableEntry(724, "Spain", "ESP");
            Countries[732] = new CountryTableEntry(732, "Western Sahara", "ESH"); 
            Countries[736] = new CountryTableEntry(736, "Sudan", "SDN");
            Countries[740] = new CountryTableEntry(740, "Suriname", "SUR");
            Countries[744] = new CountryTableEntry(744, "Svalbard and Jan Mayen", "SJM");
            Countries[748] = new CountryTableEntry(748, "Swaziland", "SWZ");
            Countries[752] = new CountryTableEntry(752, "Sweden", "SWE");
            Countries[756] = new CountryTableEntry(756, "Switzerland", "CHE");
            Countries[760] = new CountryTableEntry(760, "Syrian Arab Republic", "SYR");
            Countries[762] = new CountryTableEntry(762, "Tajikistan", "TJK");
            Countries[764] = new CountryTableEntry(764, "Thailand", "THA");
            Countries[768] = new CountryTableEntry(768, "Togo", "TGO");
            Countries[772] = new CountryTableEntry(772, "Tokelau", "TKL");
            Countries[776] = new CountryTableEntry(776, "Tonga", "TON");
            Countries[780] = new CountryTableEntry(780, "Trinidad and Tobago", "TTO");
            Countries[784] = new CountryTableEntry(784, "United Arab Emirates", "ARE"); 
            Countries[788] = new CountryTableEntry(788, "Tunisia", "TUN");
            Countries[792] = new CountryTableEntry(792, "Turkey", "TUR");
            Countries[795] = new CountryTableEntry(795, "Turkmenistan", "TKM");
            Countries[796] = new CountryTableEntry(796, "Turks and Caicos Islands", "TCA");
            Countries[798] = new CountryTableEntry(798, "Tuvalu", "TUV");
            Countries[800] = new CountryTableEntry(800, "Uganda", "UGA");
            Countries[804] = new CountryTableEntry(804, "Ukraine", "UKR");
            Countries[807] = new CountryTableEntry(807, "Macedonia, the former Yugoslav Republic of", "MKD");
            Countries[818] = new CountryTableEntry(818, "Egypt", "EGY");
            Countries[826] = new CountryTableEntry(826, "United Kingdom", "GBR");
            Countries[831] = new CountryTableEntry(831, "Guernsey", "GGY");
            Countries[832] = new CountryTableEntry(832, "Jersey", "JEY"); 
            Countries[833] = new CountryTableEntry(833, "Isle of Man", "IMN"); 
            Countries[834] = new CountryTableEntry(834, "Tanzania, United Republic of", "TZA");
            Countries[840] = new CountryTableEntry(840, "United States", "USA");
            Countries[850] = new CountryTableEntry(850, "Virgin Islands, U.S.", "VIR");
            Countries[854] = new CountryTableEntry(854, "Burkina Faso", "BFA");
            Countries[858] = new CountryTableEntry(858, "Uruguay", "URY");
            Countries[860] = new CountryTableEntry(860, "Uzbekistan", "UZB");
            Countries[862] = new CountryTableEntry(862, "Venezuela, Bolivarian Republic of", "VEN");
            Countries[876] = new CountryTableEntry(876, "Wallis and Futuna", "WLF");
            Countries[882] = new CountryTableEntry(882, "Samoa", "WSM");
            Countries[887] = new CountryTableEntry(887, "Yemen", "YEM");
            Countries[894] = new CountryTableEntry(894, "Zambia", "ZMB");

            Afghanistan = new Country(4);
            Albania = new Country(8);
            Antarctica = new Country(10);
            Algeria = new Country(12);
            AmericanSamoa = new Country(16);
            Andorra = new Country(20);
            Angola = new Country(24);
            AntiguaAndBarbuda = new Country(28);
            Azerbaijan = new Country(31);
            Argentina = new Country(32);
            Australia = new Country(36);
            Austria = new Country(40);
            Bahamas = new Country(44);
            Bahrain = new Country(48);
            Bangladesh = new Country(50);
            Armenia = new Country(51);
            Barbados = new Country(52);
            Belgium = new Country(56);
            Bermuda = new Country(60);
            Bhutan = new Country(64);
            Bolivia = new Country(68);
            BosniaAndHerzegovina = new Country(70);
            Botswana = new Country(72);
            BouvetIsland = new Country(74);
            Brazil = new Country(76);
            Belize = new Country(84);
            BritishIndianOceanTerritory = new Country(86);
            SolomonIslands = new Country(90);
            BritishVirginIslands = new Country(92);
            BruneiDarussalam = new Country(96);
            Bulgaria = new Country(100);
            Myanmar = new Country(104);
            Burundi = new Country(108);
            Belarus = new Country(112);
            Cambodia = new Country(116);
            Cameroon = new Country(120);
            Canada = new Country(124);
            CapeVerde = new Country(132);
            CaymanIslands = new Country(136);
            CentralAfricanRepublic = new Country(140);
            SriLanka = new Country(144);
            Chad = new Country(148);
            Chile = new Country(152);
            China = new Country(156);
            Taiwan = new Country(158);
            ChristmasIsland = new Country(162);
            CocosIslands = new Country(166);
            Colombia = new Country(170);
            Comoros = new Country(174);
            Mayotte = new Country(175);
            Congo = new Country(178);
            CongoDemocraticRepublic = new Country(180);
            CookIslands = new Country(184);
            CostaRica = new Country(188);
            Croatia = new Country(191);
            Cuba = new Country(192);
            Cyprus = new Country(196);
            CzechRepublic = new Country(203);
            Benin = new Country(204);
            Denmark = new Country(208);
            Dominica = new Country(212);
            DominicanRepublic = new Country(214);
            Ecuador = new Country(218);
            ElSalvador = new Country(222);
            EquatorialGuinea = new Country(226);
            Ethiopia = new Country(231);
            Eritrea = new Country(232);
            Estonia = new Country(233);
            FaroeIslands = new Country(234);
            FalklandIslands = new Country(238);
            SouthGeorgiaAndTheSouthSandwichIslands = new Country(239);
            Fiji = new Country(242);
            Finland = new Country(246);
            AlandIslands = new Country(248);
            France = new Country(250);
            FrenchGuiana = new Country(254);
            FrenchPolynesia = new Country(258);
            FrenchSouthernTerritories = new Country(260);
            Djibouti = new Country(262);
            Gabon = new Country(266);
            Georgia = new Country(268);
            Gambia = new Country(270);
            PalestinianTerritory = new Country(275);
            Germany = new Country(276);
#pragma warning disable 612,618
            EastGermany = new Country(278);
            WestGermany = new Country(280);
#pragma warning restore 612,618
            Ghana = new Country(288);
            Gibraltar = new Country(292);
            Kiribati = new Country(296);
            Greece = new Country(300);
            Greenland = new Country(304);
            Grenada = new Country(308);
            Guadeloupe = new Country(312);
            Guam = new Country(316);
            Guatemala = new Country(320);
            Guinea = new Country(324);
            Guyana = new Country(328);
            Haiti = new Country(332);
            HeardIslandAndMcDonaldIslands = new Country(334);
            VaticanCityState = new Country(336);
            Honduras = new Country(340);
            HongKong = new Country(344);
            Hungary = new Country(348);
            Iceland = new Country(352);
            India = new Country(356);
            Indonesia = new Country(360);
            Iran = new Country(364);
            Iraq = new Country(368);
            Ireland = new Country(372);
            Israel = new Country(376);
            Italy = new Country(380);
            IvoryCote = new Country(384);
            Jamaica = new Country(388);
            Japan = new Country(392);
            Kazakhstan = new Country(398);
            Jordan = new Country(400);
            Kenya = new Country(404);
            KoreaDemocraticPeoplesRepublic = new Country(408);
            KoreaRepublic = new Country(410);
            Kuwait = new Country(414);
            Kyrgyzstan = new Country(417);
            Lao = new Country(418);
            Lebanon = new Country(422);
            Lesotho = new Country(426);
            Latvia = new Country(428);
            Liberia = new Country(430);
            LibyanArabJamahiriya = new Country(434);
            Liechtenstein = new Country(438);
            Lithuania = new Country(440);
            Luxembourg = new Country(442);
            Macao = new Country(446);
            Madagascar = new Country(450);
            Malawi = new Country(454);
            Malaysia = new Country(458);
            Maldives = new Country(462);
            Mali = new Country(466);
            Malta = new Country(470);
            Martinique = new Country(474);
            Mauritania = new Country(478);
            Mauritius = new Country(480);
            Mexico = new Country(484);
            Monaco = new Country(492);
            Mongolia = new Country(496);
            Moldova = new Country(498);
            Montenegro = new Country(499);
            Montserrat = new Country(500);
            Morocco = new Country(504);
            Mozambique = new Country(508);
            Oman = new Country(512);
            Namibia = new Country(516);
            Nauru = new Country(520);
            Nepal = new Country(524);
            Netherlands = new Country(528);
            Curaçao = new Country(531);
            Aruba = new Country(533);
            SintMaarten = new Country(534);
            BonaireSaintEustatiusAndSaba = new Country(535);
            NewCaledonia = new Country(540);
            Vanuatu = new Country(548);
            NewZealand = new Country(554);
            Nicaragua = new Country(558);
            Niger = new Country(562);
            Nigeria = new Country(566);
            Niue = new Country(570);
            NorfolkIsland = new Country(574);
            Norway = new Country(578);
            NorthernMarianaIslands = new Country(580);
            UnitedStatesMinorOutlyingIslands = new Country(581);
            Micronesia = new Country(583);
            MarshallIslands = new Country(584);
            Palau = new Country(585);
            Pakistan = new Country(586);
            Panama = new Country(591);
            PapuaNewGuinea = new Country(598);
            Paraguay = new Country(600);
            Peru = new Country(604);
            Philippines = new Country(608);
            Pitcairn = new Country(612);
            Poland = new Country(616);
            Portugal = new Country(620);
            GuineaBissau = new Country(624);
            TimorLeste = new Country(626);
            PuertoRico = new Country(630);
            Qatar = new Country(634);
            Reunion = new Country(638);
            Romania = new Country(642);
            RussianFederation = new Country(643);
            Rwanda = new Country(646);
            SaintBarthélemy = new Country(652);
            SaintHelenaAscensionAndTristanDaCunha = new Country(654);
            SaintKittsAndNevis = new Country(659);
            Anguilla = new Country(660);
            SaintLucia = new Country(662);
            SaintMartin = new Country(663);
            SaintPierreAndMiquelon = new Country(666);
            SaintVincentAndGrenadines = new Country(670);
            SanMarino = new Country(674);
            SaoTomeAndPrincipe = new Country(678);
            SaudiArabia = new Country(682);
            Senegal = new Country(686);
            Serbia = new Country(688);
            Seychelles = new Country(690);
            SierraLeone = new Country(694);
            Singapore = new Country(702);
            Slovakia = new Country(703);
            VietNam = new Country(704);
            Slovenia = new Country(705);
            Somalia = new Country(706);
            SouthAfrica = new Country(710);
            Zimbabwe = new Country(716);
            Spain = new Country(724);
            WesternSahara = new Country(732);
            Sudan = new Country(736);
            Suriname = new Country(740);
            SvalbardAndJanMayen = new Country(744);
            Swaziland = new Country(748);
            Sweden = new Country(752);
            Switzerland = new Country(756);
            SyrianArabRepublic = new Country(760);
            Tajikistan = new Country(762);
            Thailand = new Country(764);
            Togo = new Country(768);
            Tokelau = new Country(772);
            Tonga = new Country(776);
            TrinidadAndTobago = new Country(780);
            UnitedArabEmirates = new Country(784);
            Tunisia = new Country(788);
            Turkey = new Country(792);
            Turkmenistan = new Country(795);
            TurksAndCaicosIslands = new Country(796);
            Tuvalu = new Country(798);
            Uganda = new Country(800);
            Ukraine = new Country(804);
            Macedonia = new Country(807);
            Egypt = new Country(818);
            UnitedKingdom = new Country(826);
            Guernsey = new Country(831);
            Jersey = new Country(832);
            IsleOfMan = new Country(833);
            Tanzania = new Country(834);
            UnitedStates = new Country(840);
            VirginIslands = new Country(850);
            BurkinaFaso = new Country(854);
            Uruguay = new Country(858);
            Uzbekistan = new Country(860);
            Venezuela = new Country(862);
            WallisAndFutuna = new Country(876);
            Samoa = new Country(882);
            Yemen = new Country(887);
            Zambia = new Country(894);
        }

        #endregion

        /// <summary>
        /// Parses the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static Country Parse(IEmvElement value)
        {
            if (value == null || value.Value == null)
            {
                throw new ArgumentNullException("value", "IEmvElement argument was null for Country.Parse");
            }

            if (value.Value.Length > 2)
            {
                return null;
            }

            return new Country(int.Parse(value.Value.FromBcd()));
        }

        /// <summary>
        /// Tries the parse.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static bool TryParse(IEmvElement value, out Country item)
        {
            try
            {
                item = Parse(value);
                return true;
            }
            catch
            {
                var code = int.Parse(value.Value.FromBcd());
                item = new Country { Code = code, Name = "Unknown", Alpha3 = "XXX" };
                return false;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Country"/> class.
        /// </summary>
        private Country()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Country"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
        public Country(int code)
        {
            if (!Countries.ContainsKey(code))
            {
                throw new ArgumentOutOfRangeException("code",
                                                      code,
                                                      @"The value isn't a valid ISO 3166 country code.");
            }

            var el = Countries[code];
            Code = el.Code;
            Name = el.Name;
            Alpha3 = el.Alpha3;
        }

        /// <summary>
        /// 
        /// </summary>
        public int Code { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the ISO 3166-1 alpha-3 codes that are the three-letter country codes defined in ISO 3166-1
        /// </summary>
        public string Alpha3 { get; private set; }

        #region IEquatable<Country>

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.
        ///                 </param>
        public bool Equals(Country other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.Code == Code;
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>. 
        ///                 </param><exception cref="T:System.NullReferenceException">The <paramref name="obj"/> parameter is null.
        ///                 </exception><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != typeof(Country))
            {
                return false;
            }
            return Equals((Country)obj);
        }

        /// <summary>
        /// Serves as a hash function for a particular type. 
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            return Code;
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(Country left, Country right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(Country left, Country right)
        {
            return !Equals(left, right);
        }

        #endregion

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return string.Format("Code: {0,3} ['{1}'] {2}", Code, Alpha3, Name);
        }

        #region Private Members

        private struct CountryTableEntry
        {
            internal readonly int Code;

            internal readonly string Name;

            internal readonly string Alpha3;

            internal CountryTableEntry(int code, string name, string alpha3)
            {
                Code = code;
                Name = name;
                Alpha3 = alpha3;
            }
        }

        #endregion
    }
}