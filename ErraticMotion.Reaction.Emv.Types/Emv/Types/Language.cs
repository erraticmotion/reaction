namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents an ISO 639-2, two letter code, used with <see cref="LanguagePreference"/> EMV Tag 5F2D
    /// </summary>
    public sealed class Language : IEquatable<Language>
    {
        #region Static Members

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Undefined;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Abkhaz;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Afar;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Afrikaans;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Akan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Albanian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Amharic;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Arabic;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Aragonese;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Armenian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Assamese;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Avaric;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Avestan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Aymara;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Azerbaijani;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Bambara;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Bashkir;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Basque;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Belarusian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Bengali;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Bihari;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Bislama;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Bosnian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Breton;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Bulgarian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Burmese;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Catalan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Chamorro;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Chechen;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Chichewa;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Chinese;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Chuvash;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Cornish;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Corsican;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Cree;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Croatian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Czech;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Danish;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Divehi;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Dutch;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Dzongkha;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language English;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Esperanto;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Estonian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Ewe;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Faroese;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Fijian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Finnish;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language French;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Fula;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Galician;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Georgian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language German;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Greek;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Guaraní;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Gujarati;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Haitian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Hausa;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Hebrew;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Herero;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Hindi;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language HiriMotu;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Hungarian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Interlingua;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Indonesian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Interlingue;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Irish;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Igbo;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Inupiaq;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Ido;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Icelandic;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Italian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Inuktitut;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Japanese;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Javanese;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Kalaallisut;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Kannada;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Kanuri;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Kashmiri;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Kazakh;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Khmer;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Kikuyu;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Kinyarwanda;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Kirghiz;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Komi;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Kongo;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Korean;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Kurdish;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Kwanyama;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Latin;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Luxembourgish;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Luganda;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Limburgish;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Lingala;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Lao;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Lithuanian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language LubaKatanga;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Latvian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Manx;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Macedonian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Malagasy;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Malay;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Malayalam;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Maltese;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Māori;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Marathi;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Marshallese;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Mongolian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Nauru;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Navajo;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language NorwegianBokmal;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language NorthNdebele;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Nepali;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Ndonga;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language NorwegianNynorsk;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Norwegian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Nuosu;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language SouthNdebele;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Occitan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Ojibwe;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language OldChurchSlavonic;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Oromo;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Oriya;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Ossetian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Panjabi;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Pali;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Persian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Polish;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Pashto;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Portuguese;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Quechua;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Romansh;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Kirundi;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Romanian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Russian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Sanskrit;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Sardinian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Sindhi;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language NorthernSami;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Samoan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Sango;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Serbian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Gaelic;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Shona;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Sinhala;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Slovak;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Slovene;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Somali;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language SouthernSotho;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Spanish;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Sundanese;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Swahili;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Swati;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Swedish;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Tamil;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Telugu;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Tajik;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Thai;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Tigrinya;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Tibetan;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Turkmen;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Tagalog;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Tswana;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Tonga;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Turkish;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Tsonga;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Tatar;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Twi;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Tahitian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Uighur;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Ukrainian;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Urdu;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Uzbek;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Venda;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Vietnamese;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Volapük;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Walloon;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Welsh;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Wolof;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Western;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Xhosa;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Yiddish;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Yoruba;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Zhuang;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Language Zulu;

        #endregion

        #region Static Ctor

        private static readonly Dictionary<string, LanguageTableEntry> Languages =
            new Dictionary<string, LanguageTableEntry>();

        static Language()
        {
            Languages["xx"] = new LanguageTableEntry("xx", "Undefined");
            Languages["ab"] = new LanguageTableEntry("ab", "Abkhaz");
            Languages["aa"] = new LanguageTableEntry("aa", "Afar");
            Languages["af"] = new LanguageTableEntry("af", "Afrikaans");
            Languages["ak"] = new LanguageTableEntry("ak", "Akan");
            Languages["sq"] = new LanguageTableEntry("sq", "Albanian");
            Languages["am"] = new LanguageTableEntry("am", "Amharic");
            Languages["ar"] = new LanguageTableEntry("ar", "Arabic");
            Languages["an"] = new LanguageTableEntry("an", "Aragonese");
            Languages["hy"] = new LanguageTableEntry("hy", "Armenian");
            Languages["as"] = new LanguageTableEntry("as", "Assamese");
            Languages["av"] = new LanguageTableEntry("av", "Avaric");
            Languages["ae"] = new LanguageTableEntry("ae", "Avestan");
            Languages["ay"] = new LanguageTableEntry("ay", "Aymara");
            Languages["az"] = new LanguageTableEntry("az", "Azerbaijani");
            Languages["bm"] = new LanguageTableEntry("bm", "Bambara");
            Languages["ba"] = new LanguageTableEntry("ba", "Bashkir");
            Languages["eu"] = new LanguageTableEntry("eu", "Basque");
            Languages["be"] = new LanguageTableEntry("be", "Belarusian");
            Languages["bn"] = new LanguageTableEntry("bn", "Bengali");
            Languages["bh"] = new LanguageTableEntry("bh", "Bihari");
            Languages["bi"] = new LanguageTableEntry("bi", "Bislama");
            Languages["bs"] = new LanguageTableEntry("bs", "Bosnian");
            Languages["br"] = new LanguageTableEntry("br", "Breton");
            Languages["bg"] = new LanguageTableEntry("bg", "Bulgarian");
            Languages["my"] = new LanguageTableEntry("my", "Burmese");
            Languages["ca"] = new LanguageTableEntry("ca", "Catalan");
            Languages["ch"] = new LanguageTableEntry("ch", "Chamorro");
            Languages["ce"] = new LanguageTableEntry("ce", "Chechen");
            Languages["ny"] = new LanguageTableEntry("ny", "Chichewa");
            Languages["zh"] = new LanguageTableEntry("zh", "Chinese");
            Languages["cv"] = new LanguageTableEntry("cv", "Chuvash");
            Languages["kw"] = new LanguageTableEntry("kw", "Cornish");
            Languages["co"] = new LanguageTableEntry("co", "Corsican");
            Languages["cr"] = new LanguageTableEntry("cr", "Cree");
            Languages["hr"] = new LanguageTableEntry("hr", "Croatian");
            Languages["cs"] = new LanguageTableEntry("cs", "Czech");
            Languages["da"] = new LanguageTableEntry("da", "Danish");
            Languages["dv"] = new LanguageTableEntry("dv", "Divehi");
            Languages["nl"] = new LanguageTableEntry("nl", "Dutch");
            Languages["dz"] = new LanguageTableEntry("dz", "Dzongkha");
            Languages["en"] = new LanguageTableEntry("en", "English");
            Languages["eo"] = new LanguageTableEntry("eo", "Esperanto");
            Languages["et"] = new LanguageTableEntry("et", "Estonian");
            Languages["ee"] = new LanguageTableEntry("ee", "Ewe");
            Languages["fo"] = new LanguageTableEntry("fo", "Faroese");
            Languages["fj"] = new LanguageTableEntry("fj", "Fijian");
            Languages["fi"] = new LanguageTableEntry("fi", "Finnish");
            Languages["fr"] = new LanguageTableEntry("fr", "French");
            Languages["ff"] = new LanguageTableEntry("ff", "Fula");
            Languages["gl"] = new LanguageTableEntry("gl", "Galician");
            Languages["ka"] = new LanguageTableEntry("ka", "Georgian");
            Languages["de"] = new LanguageTableEntry("de", "German");
            Languages["el"] = new LanguageTableEntry("el", "Greek");
            Languages["gn"] = new LanguageTableEntry("gn", "Guaraní");
            Languages["gu"] = new LanguageTableEntry("gu", "Gujarati");
            Languages["ht"] = new LanguageTableEntry("ht", "Haitian");
            Languages["ha"] = new LanguageTableEntry("ha", "Hausa");
            Languages["he"] = new LanguageTableEntry("he", "Hebrew");
            Languages["hz"] = new LanguageTableEntry("hz", "Herero");
            Languages["hi"] = new LanguageTableEntry("hi", "Hindi");
            Languages["ho"] = new LanguageTableEntry("ho", "HiriMotu");
            Languages["hu"] = new LanguageTableEntry("hu", "Hungarian");
            Languages["ia"] = new LanguageTableEntry("ia", "Interlingua");
            Languages["id"] = new LanguageTableEntry("id", "Indonesian");
            Languages["ie"] = new LanguageTableEntry("ie", "Interlingue");
            Languages["ga"] = new LanguageTableEntry("ga", "Irish");
            Languages["ig"] = new LanguageTableEntry("ig", "Igbo");
            Languages["ik"] = new LanguageTableEntry("ik", "Inupiaq");
            Languages["io"] = new LanguageTableEntry("io", "Ido");
            Languages["is"] = new LanguageTableEntry("is", "Icelandic");
            Languages["it"] = new LanguageTableEntry("it", "Italian");
            Languages["iu"] = new LanguageTableEntry("iu", "Inuktitut");
            Languages["ja"] = new LanguageTableEntry("ja", "Japanese");
            Languages["jv"] = new LanguageTableEntry("jv", "Javanese");
            Languages["kl"] = new LanguageTableEntry("kl", "Kalaallisut");
            Languages["kn"] = new LanguageTableEntry("kn", "Kannada");
            Languages["kr"] = new LanguageTableEntry("kr", "Kanuri");
            Languages["ks"] = new LanguageTableEntry("ks", "Kashmiri");
            Languages["kk"] = new LanguageTableEntry("kk", "Kazakh");
            Languages["km"] = new LanguageTableEntry("km", "Khmer");
            Languages["ki"] = new LanguageTableEntry("ki", "Kikuyu");
            Languages["rw"] = new LanguageTableEntry("rw", "Kinyarwanda");
            Languages["ky"] = new LanguageTableEntry("ky", "Kirghiz");
            Languages["kv"] = new LanguageTableEntry("kv", "Komi");
            Languages["kg"] = new LanguageTableEntry("kg", "Kongo");
            Languages["ko"] = new LanguageTableEntry("ko", "Korean");
            Languages["ku"] = new LanguageTableEntry("ku", "Kurdish");
            Languages["kj"] = new LanguageTableEntry("kj", "Kwanyama");
            Languages["la"] = new LanguageTableEntry("la", "Latin");
            Languages["lb"] = new LanguageTableEntry("lb", "Luxembourgish");
            Languages["lg"] = new LanguageTableEntry("lg", "Luganda");
            Languages["li"] = new LanguageTableEntry("li", "Limburgish");
            Languages["ln"] = new LanguageTableEntry("ln", "Lingala");
            Languages["lo"] = new LanguageTableEntry("lo", "Lao");
            Languages["lt"] = new LanguageTableEntry("lt", "Lithuanian");
            Languages["lu"] = new LanguageTableEntry("lu", "Luba-Katanga");
            Languages["lv"] = new LanguageTableEntry("lv", "Latvian");
            Languages["gv"] = new LanguageTableEntry("gv", "Manx");
            Languages["mk"] = new LanguageTableEntry("mk", "Macedonian");
            Languages["mg"] = new LanguageTableEntry("mg", "Malagasy");
            Languages["ms"] = new LanguageTableEntry("ms", "Malay");
            Languages["ml"] = new LanguageTableEntry("ml", "Malayalam");
            Languages["mt"] = new LanguageTableEntry("mt", "Maltese");
            Languages["mi"] = new LanguageTableEntry("mi", "Māori");
            Languages["mr"] = new LanguageTableEntry("mr", "Marathi");
            Languages["mh"] = new LanguageTableEntry("mh", "Marshallese");
            Languages["mn"] = new LanguageTableEntry("mn", "Mongolian");
            Languages["na"] = new LanguageTableEntry("na", "Nauru");
            Languages["nv"] = new LanguageTableEntry("nv", "Navajo");
            Languages["nb"] = new LanguageTableEntry("nb", "NorwegianBokmal");
            Languages["nd"] = new LanguageTableEntry("nd", "NorthNdebele");
            Languages["ne"] = new LanguageTableEntry("ne", "Nepali");
            Languages["ng"] = new LanguageTableEntry("ng", "Ndonga");
            Languages["nn"] = new LanguageTableEntry("nn", "NorwegianNynorsk");
            Languages["no"] = new LanguageTableEntry("no", "Norwegian");
            Languages["ii"] = new LanguageTableEntry("ii", "Nuosu");
            Languages["nr"] = new LanguageTableEntry("nr", "SouthNdebele");
            Languages["oc"] = new LanguageTableEntry("oc", "Occitan");
            Languages["oj"] = new LanguageTableEntry("oj", "Ojibwe");
            Languages["cu"] = new LanguageTableEntry("cu", "OldChurchSlavonic");
            Languages["om"] = new LanguageTableEntry("om", "Oromo");
            Languages["or"] = new LanguageTableEntry("or", "Oriya");
            Languages["os"] = new LanguageTableEntry("os", "Ossetian");
            Languages["pa"] = new LanguageTableEntry("pa", "Panjabi");
            Languages["pi"] = new LanguageTableEntry("pi", "Pali");
            Languages["fa"] = new LanguageTableEntry("fa", "Persian");
            Languages["pl"] = new LanguageTableEntry("pl", "Polish");
            Languages["ps"] = new LanguageTableEntry("ps", "Pashto");
            Languages["pt"] = new LanguageTableEntry("pt", "Portuguese");
            Languages["qu"] = new LanguageTableEntry("qu", "Quechua");
            Languages["rm"] = new LanguageTableEntry("rm", "Romansh");
            Languages["rn"] = new LanguageTableEntry("rn", "Kirundi");
            Languages["ro"] = new LanguageTableEntry("ro", "Romanian");
            Languages["ru"] = new LanguageTableEntry("ru", "Russian");
            Languages["sa"] = new LanguageTableEntry("sa", "Sanskrit");
            Languages["sc"] = new LanguageTableEntry("sc", "Sardinian");
            Languages["sd"] = new LanguageTableEntry("sd", "Sindhi");
            Languages["se"] = new LanguageTableEntry("se", "NorthernSami");
            Languages["sm"] = new LanguageTableEntry("sm", "Samoan");
            Languages["sg"] = new LanguageTableEntry("sg", "Sango");
            Languages["sr"] = new LanguageTableEntry("sr", "Serbian");
            Languages["gd"] = new LanguageTableEntry("gd", "Gaelic");
            Languages["sn"] = new LanguageTableEntry("sn", "Shona");
            Languages["si"] = new LanguageTableEntry("si", "Sinhala");
            Languages["sk"] = new LanguageTableEntry("sk", "Slovak");
            Languages["sl"] = new LanguageTableEntry("sl", "Slovene");
            Languages["so"] = new LanguageTableEntry("so", "Somali");
            Languages["st"] = new LanguageTableEntry("st", "SouthernSotho");
            Languages["es"] = new LanguageTableEntry("es", "Spanish");
            Languages["su"] = new LanguageTableEntry("su", "Sundanese");
            Languages["sw"] = new LanguageTableEntry("sw", "Swahili");
            Languages["ss"] = new LanguageTableEntry("ss", "Swati");
            Languages["sv"] = new LanguageTableEntry("sv", "Swedish");
            Languages["ta"] = new LanguageTableEntry("ta", "Tamil");
            Languages["te"] = new LanguageTableEntry("te", "Telugu");
            Languages["tg"] = new LanguageTableEntry("tg", "Tajik");
            Languages["th"] = new LanguageTableEntry("th", "Thai");
            Languages["ti"] = new LanguageTableEntry("ti", "Tigrinya");
            Languages["bo"] = new LanguageTableEntry("bo", "Tibetan");
            Languages["tk"] = new LanguageTableEntry("tk", "Turkmen");
            Languages["tl"] = new LanguageTableEntry("tl", "Tagalog");
            Languages["tn"] = new LanguageTableEntry("tn", "Tswana");
            Languages["to"] = new LanguageTableEntry("to", "Tonga");
            Languages["tr"] = new LanguageTableEntry("tr", "Turkish");
            Languages["ts"] = new LanguageTableEntry("ts", "Tsonga");
            Languages["tt"] = new LanguageTableEntry("tt", "Tatar");
            Languages["tw"] = new LanguageTableEntry("tw", "Twi");
            Languages["ty"] = new LanguageTableEntry("ty", "Tahitian");
            Languages["ug"] = new LanguageTableEntry("ug", "Uighur");
            Languages["uk"] = new LanguageTableEntry("uk", "Ukrainian");
            Languages["ur"] = new LanguageTableEntry("ur", "Urdu");
            Languages["uz"] = new LanguageTableEntry("uz", "Uzbek");
            Languages["ve"] = new LanguageTableEntry("ve", "Venda");
            Languages["vi"] = new LanguageTableEntry("vi", "Vietnamese");
            Languages["vo"] = new LanguageTableEntry("vo", "Volapük");
            Languages["wa"] = new LanguageTableEntry("wa", "Walloon");
            Languages["cy"] = new LanguageTableEntry("cy", "Welsh");
            Languages["wo"] = new LanguageTableEntry("wo", "Wolof");
            Languages["fy"] = new LanguageTableEntry("fy", "Western");
            Languages["xh"] = new LanguageTableEntry("xh", "Xhosa");
            Languages["yi"] = new LanguageTableEntry("yi", "Yiddish");
            Languages["yo"] = new LanguageTableEntry("yo", "Yoruba");
            Languages["za"] = new LanguageTableEntry("za", "Zhuang");
            Languages["zu"] = new LanguageTableEntry("zu", "Zulu");

            Undefined = new Language("xx");
            Abkhaz = new Language("ab");
            Afar = new Language("aa");
            Afrikaans = new Language("af");
            Akan = new Language("ak");
            Albanian = new Language("sq");
            Amharic = new Language("am");
            Arabic = new Language("ar");
            Aragonese = new Language("an");
            Armenian = new Language("hy");
            Assamese = new Language("as");
            Avaric = new Language("av");
            Avestan = new Language("ae");
            Aymara = new Language("ay");
            Azerbaijani = new Language("az");
            Bambara = new Language("bm");
            Bashkir = new Language("ba");
            Basque = new Language("eu");
            Belarusian = new Language("be");
            Bengali = new Language("bn");
            Bihari = new Language("bh");
            Bislama = new Language("bi");
            Bosnian = new Language("bs");
            Breton = new Language("br");
            Bulgarian = new Language("bg");
            Burmese = new Language("my");
            Catalan = new Language("ca");
            Chamorro = new Language("ch");
            Chechen = new Language("ce");
            Chichewa = new Language("ny");
            Chinese = new Language("zh");
            Chuvash = new Language("cv");
            Cornish = new Language("kw");
            Corsican = new Language("co");
            Cree = new Language("cr");
            Croatian = new Language("hr");
            Czech = new Language("cs");
            Danish = new Language("da");
            Divehi = new Language("dv");
            Dutch = new Language("nl");
            Dzongkha = new Language("dz");
            English = new Language("en");
            Esperanto = new Language("eo");
            Estonian = new Language("et");
            Ewe = new Language("ee");
            Faroese = new Language("fo");
            Fijian = new Language("fj");
            Finnish = new Language("fi");
            French = new Language("fr");
            Fula = new Language("ff");
            Galician = new Language("gl");
            Georgian = new Language("ka");
            German = new Language("de");
            Greek = new Language("el");
            Guaraní = new Language("gn");
            Gujarati = new Language("gu");
            Haitian = new Language("ht");
            Hausa = new Language("ha");
            Hebrew = new Language("he");
            Herero = new Language("hz");
            Hindi = new Language("hi");
            HiriMotu = new Language("ho");
            Hungarian = new Language("hu");
            Interlingua = new Language("ia");
            Indonesian = new Language("id");
            Interlingue = new Language("ie");
            Irish = new Language("ga");
            Igbo = new Language("ig");
            Inupiaq = new Language("ik");
            Ido = new Language("io");
            Icelandic = new Language("is");
            Italian = new Language("it");
            Inuktitut = new Language("iu");
            Japanese = new Language("ja");
            Javanese = new Language("jv");
            Kalaallisut = new Language("kl");
            Kannada = new Language("kn");
            Kanuri = new Language("kr");
            Kashmiri = new Language("ks");
            Kazakh = new Language("kk");
            Khmer = new Language("km");
            Kikuyu = new Language("ki");
            Kinyarwanda = new Language("rw");
            Kirghiz = new Language("ky");
            Komi = new Language("kv");
            Kongo = new Language("kg");
            Korean = new Language("ko");
            Kurdish = new Language("ku");
            Kwanyama = new Language("kj");
            Latin = new Language("la");
            Luxembourgish = new Language("lb");
            Luganda = new Language("lg");
            Limburgish = new Language("li");
            Lingala = new Language("ln");
            Lao = new Language("lo");
            Lithuanian = new Language("lt");
            LubaKatanga = new Language("lu");
            Latvian = new Language("lv");
            Manx = new Language("gv");
            Macedonian = new Language("mk");
            Malagasy = new Language("mg");
            Malay = new Language("ms");
            Malayalam = new Language("ml");
            Maltese = new Language("mt");
            Māori = new Language("mi");
            Marathi = new Language("mr");
            Marshallese = new Language("mh");
            Mongolian = new Language("mn");
            Nauru = new Language("na");
            Navajo = new Language("nv");
            NorwegianBokmal = new Language("nb");
            NorthNdebele = new Language("nd");
            Nepali = new Language("ne");
            Ndonga = new Language("ng");
            NorwegianNynorsk = new Language("nn");
            Norwegian = new Language("no");
            Nuosu = new Language("ii");
            SouthNdebele = new Language("nr");
            Occitan = new Language("oc");
            Ojibwe = new Language("oj");
            OldChurchSlavonic = new Language("cu");
            Oromo = new Language("om");
            Oriya = new Language("or");
            Ossetian = new Language("os");
            Panjabi = new Language("pa");
            Pali = new Language("pi");
            Persian = new Language("fa");
            Polish = new Language("pl");
            Pashto = new Language("ps");
            Portuguese = new Language("pt");
            Quechua = new Language("qu");
            Romansh = new Language("rm");
            Kirundi = new Language("rn");
            Romanian = new Language("ro");
            Russian = new Language("ru");
            Sanskrit = new Language("sa");
            Sardinian = new Language("sc");
            Sindhi = new Language("sd");
            NorthernSami = new Language("se");
            Samoan = new Language("sm");
            Sango = new Language("sg");
            Serbian = new Language("sr");
            Gaelic = new Language("gd");
            Shona = new Language("sn");
            Sinhala = new Language("si");
            Slovak = new Language("sk");
            Slovene = new Language("sl");
            Somali = new Language("so");
            SouthernSotho = new Language("st");
            Spanish = new Language("es");
            Sundanese = new Language("su");
            Swahili = new Language("sw");
            Swati = new Language("ss");
            Swedish = new Language("sv");
            Tamil = new Language("ta");
            Telugu = new Language("te");
            Tajik = new Language("tg");
            Thai = new Language("th");
            Tigrinya = new Language("ti");
            Tibetan = new Language("bo");
            Turkmen = new Language("tk");
            Tagalog = new Language("tl");
            Tswana = new Language("tn");
            Tonga = new Language("to");
            Turkish = new Language("tr");
            Tsonga = new Language("ts");
            Tatar = new Language("tt");
            Twi = new Language("tw");
            Tahitian = new Language("ty");
            Uighur = new Language("ug");
            Ukrainian = new Language("uk");
            Urdu = new Language("ur");
            Uzbek = new Language("uz");
            Venda = new Language("ve");
            Vietnamese = new Language("vi");
            Volapük = new Language("vo");
            Walloon = new Language("wa");
            Welsh = new Language("cy");
            Wolof = new Language("wo");
            Western = new Language("fy");
            Xhosa = new Language("xh");
            Yiddish = new Language("yi");
            Yoruba = new Language("yo");
            Zhuang = new Language("za");
            Zulu = new Language("zu");

        }

        #endregion

        /// <summary>
        /// Parses the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static Language Parse(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return Undefined;
            }

            if (value.Length != 2)
            {
                return Undefined;
            }

            try
            {
                return new Language(value.ToLowerInvariant());
            }
            catch (Exception)
            {
                return Undefined;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Language"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
        private Language(string code)
        {
            if (!Languages.ContainsKey(code))
            {
                throw new ArgumentOutOfRangeException("code",
                                                      code,
                                                      @"The value isn't a valid ISO 639-2 language code.");
            }

            var el = Languages[code];
            TwoLetterCode = el.Code;
            Name = el.Name;
        }

        /// <summary>
        /// 
        /// </summary>
        public string TwoLetterCode { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; private set; }

        #region IEquatable<Language>

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.
        ///                 </param>
        public bool Equals(Language other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return Equals(other.TwoLetterCode, TwoLetterCode);
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
            if (obj.GetType() != typeof(Language))
            {
                return false;
            }
            return Equals((Language)obj);
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
            return (TwoLetterCode != null ? TwoLetterCode.GetHashCode() : 0);
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(Language left, Language right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(Language left, Language right)
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
            return string.Format("{0}({1})", Name, TwoLetterCode);
        }

        #region Private Members

        private struct LanguageTableEntry
        {
            internal readonly string Code;

            internal readonly string Name;

            internal LanguageTableEntry(string code, string name)
            {
                Code = code;
                Name = name;
            }
        }

        #endregion
    }
}