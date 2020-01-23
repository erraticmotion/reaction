namespace ErraticMotion.Reaction.Emv.Types
{
    /// <summary>
    /// 
    /// </summary>
    public enum TagLengthValueType
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0,

        /// <summary>
        /// 0x9f01
        /// </summary>
        AquirerIdentifier2 = 0x9f01,

        /// <summary>
        /// 0x9f02
        /// </summary>
        TransactionTotalAmount = 0x9f02,

        /// <summary>
        /// 
        /// </summary>
        AmountOther = 0x9f03,

        /// <summary>
        /// 
        /// </summary>
        AmountOtherBinary = 0x9f04,

        /// <summary>
        /// 
        /// </summary>
        ApplicationDiscretionaryData = 0x9f05,

        /// <summary>
        /// 
        /// </summary>
        ApplicationIdentifierTerminal = 0x9f06,

        /// <summary>
        /// 0x9f07
        /// </summary>
        ApplicationUsageControl = 0x9f07,

        //APF-60: 0x9f08 was TerminalApplicationVersionNumber
        /// <summary>
        /// 
        /// </summary>
        ApplicationVersionNumber = 0x9f08,

        //APF-60: 0x9f09 was ApplicationVersionNumber
        /// <summary>
        /// 
        /// </summary>
        TerminalApplicationVersionNumber = 0x9f09,

        /// <summary>
        /// 
        /// </summary>
        CardholderName = 0x5f20,

        /// <summary>
        /// 
        /// </summary>
        CardMovementTrack1Data = 0x5f21,

        /// <summary>
        /// 
        /// </summary>
        CardMovementTrack2Data = 0x5f22,

        /// <summary>
        /// 
        /// </summary>
        CardMovementTrack3Data = 0x5f23,

        /// <summary>
        /// 
        /// </summary>
        ApplicationExpirationDate = 0x5f24,

        /// <summary>
        /// 
        /// </summary>
        ApplicationEffectiveDate = 0x5f25,

        /// <summary>
        /// 
        /// </summary>
        IssuerCountryCode = 0x5F28,

        /// <summary>
        /// 0x5F2A, CRYPTOGRAM CURRENCY CODE (TAG ‘5F2A’) for XPI/Moneris
        /// </summary>
        TransactionCurrencyCode = 0x5F2A,

        /// <summary>
        /// 0x5F2D
        /// </summary>
        LanguagePreference = 0x5F2D,

        /// <summary>
        /// 0x5F30
        /// </summary>
        ServiceCode = 0x5F30,

        /// <summary>
        /// 0x5F34
        /// </summary>
        PanSequenceNumber = 0x5F34,

        /// <summary>
        /// 0x5F36
        /// </summary>
        TransactionCurrencyExponent = 0x5F36,

        /// <summary>
        /// 0x5F50
        /// </summary>
        IssuerUrl = 0x5F50,

        /// <summary>
        /// 0x5F53
        /// </summary>
        InternationalBankAcctNo = 0x5F53,

        /// <summary>
        /// 
        /// </summary>
        BankIdentifierCode = 0x5F54,

        /// <summary>
        /// 
        /// </summary>
        IssuerCountryCodeAlpha2 = 0x5F55,

        /// <summary>
        /// 
        /// </summary>
        IssuerCountryCodeAlpha3 = 0x5F56,

        /// <summary>
        /// 
        /// </summary>
        CardholderNameExtended = 0x9F0B,

        /// <summary>
        /// 
        /// </summary>
        IssuerActionCodeDefault = 0x9F0D,

        /// <summary>
        /// 
        /// </summary>
        IssuerActionCodeDenial = 0x9F0E,

        /// <summary>
        /// 
        /// </summary>
        IssuerActionCodeOnline = 0x9F0F,

        /// <summary>
        /// 0x9F10
        /// </summary>
        IssuerApplicationData = 0x9F10,

        /// <summary>
        /// 
        /// </summary>
        IssuerCodeTableIndex = 0x9F11,

        /// <summary>
        /// 0x9F12
        /// </summary>
        PreferredName = 0x9F12,

        /// <summary>
        /// 
        /// </summary>
        LastOnlineAtcRegister = 0x9F13,

        /// <summary>
        /// 
        /// </summary>
        LowerConsecutiveOfflineLimit = 0x9F14,

        /// <summary>
        /// 
        /// </summary>
        MerchantCategoryCode = 0x9F15,

        /// <summary>
        /// 
        /// </summary>
        MerchantIdentifier = 0x9F16,

        /// <summary>
        /// 
        /// </summary>
        PinTryCounter = 0x9F17,

        /// <summary>
        /// 
        /// </summary>
        IssuerScriptIdentifier = 0x9F18,

        /// <summary>
        /// 0x9F1A
        /// </summary>
        TerminalCountryCode = 0x9F1A,

        /// <summary>
        /// 
        /// </summary>
        TerminalFloorLimit = 0x9F1B,

        /// <summary>
        /// 
        /// </summary>
        TerminalIdentifier = 0x9F1C,

        /// <summary>
        /// 
        /// </summary>
        TerminalRiskManagementData = 0x9F1D,

        /// <summary>
        /// 
        /// </summary>
        InterfaceDeviceSerialNumber = 0x9F1E,

        /// <summary>
        /// 
        /// </summary>
        Track1DiscretionaryData = 0x9F1F,

        /// <summary>
        /// 
        /// </summary>
        Track2DiscretionaryData = 0x9F20,

        /// <summary>
        /// 
        /// </summary>
        TransactionTime = 0x9F21,

        /// <summary>
        /// 
        /// </summary>
        CertificationAuthorityPublicKeyIndex2 = 0x9F22,

        /// <summary>
        /// 
        /// </summary>
        UpperConsecutiveOfflineLimit = 0x9F23,

        /// <summary>
        /// 
        /// </summary>
        ApplicationCryptogram = 0x9F26,

        /// <summary>
        /// 0x9F27
        /// </summary>
        CryptogramInformationData = 0x9F27,

        /// <summary>
        /// 
        /// </summary>
        IccPinEnciphermentPkCertificate = 0x9F2D,

        /// <summary>
        /// 
        /// </summary>
        IccPinEnciphermentPkExponent = 0x9F2E,

        /// <summary>
        /// 
        /// </summary>
        IccPinEnciphermentPkRemainder = 0x9F2F,

        /// <summary>
        /// 
        /// </summary>
        IssuerPublicKeyExponent = 0x9F32,

        /// <summary>
        /// 
        /// </summary>
        TerminalCapabilities = 0x9F33,

        /// <summary>
        /// 0x9F34
        /// </summary>
        CvmResults = 0x9F34,

        /// <summary>
        /// 0x8E
        /// </summary>
        CvmList = 0x8E,

        /// <summary>
        /// 
        /// </summary>
        TerminalType = 0x9F35,

        /// <summary>
        /// 0x9F36
        /// </summary>
        ApplicationTransactionCounter = 0x9F36,

        /// <summary>
        /// 0x9F37
        /// </summary>
        UnpredictableNo = 0x9F37,

        /// <summary>
        /// 
        /// </summary>
        ProcessingDol = 0x9F38,

        /// <summary>
        /// 
        /// </summary>
        PosEntryMode = 0x9F39,

        /// <summary>
        /// 
        /// </summary>
        AmountReferenceCurrency = 0x9F3A,

        /// <summary>
        /// 0x9F3B
        /// </summary>
        ApplicationReferenceCurrency = 0x9F3B,

        /// <summary>
        /// 0x9F3C
        /// </summary>
        TransactionReferenceCurrencyCode = 0x9F3C,

        /// <summary>
        /// 0x9F3D
        /// </summary>
        TransactionReferenceCurrencyExponent = 0x9F3D,

        /// <summary>
        /// 0x9F40
        /// </summary>
        AdditionalTerminalCapabilities = 0x9F40,

        /// <summary>
        /// 0x9F41
        /// </summary>
        TransactionSequenceCounter = 0x9F41,

        /// <summary>
        /// 0x9F42
        /// </summary>
        ApplicationCurrencyCode = 0x9F42,

        /// <summary>
        /// 0x9F43
        /// </summary>
        ApplicationReferenceCurrencyExponent = 0x9F43,

        /// <summary>
        /// 0x9F44
        /// </summary>
        ApplicationCurrencyExponent = 0x9F44,

        /// <summary>
        /// 0x9F45
        /// </summary>
        DataAuthenticationCode = 0x9F45,

        /// <summary>
        /// 0x9F46
        /// </summary>
        IccPkCertificate = 0x9F46,

        /// <summary>
        /// 0x9F47
        /// </summary>
        IccPkExponent = 0x9F47,

        /// <summary>
        /// 0x9F48
        /// </summary>
        IccPkRemainder = 0x9F48,

        /// <summary>
        /// 0x9F49
        /// </summary>
        DynamicDataAuthenticationDol = 0x9F49,

        /// <summary>
        /// 0x9F4A
        /// </summary>
        StaticDataAuthenticationTagList = 0x9F4A,

        /// <summary>
        /// 0x9F4B
        /// </summary>
        SignedDynamicApplicationData = 0x9F4B,

        /// <summary>
        /// 0x9F4C
        /// </summary>
        IccDynamicNo = 0x9F4C,

        /// <summary>
        /// 0x9F4D
        /// </summary>
        LogEntry = 0x9F4D,

        /// <summary>
        /// 0x9F4E
        /// </summary>
        MerchantNameAndLocation = 0x9F4E,

        /// <summary>
        /// 0x9F4F
        /// </summary>
        LogFormat = 0x9F4F,

        /// <summary>
        /// 0x5A
        /// </summary>
        PrimaryAccountNumber = 0x5A,

        /// <summary>
        /// 0x9a
        /// </summary>
        TerminalTransactionDate = 0x9a,

        /// <summary>
        /// 0x9c
        /// </summary>
        TransactionType = 0x9c,

        /// <summary>
        /// 0x9b
        /// </summary>
        TransactionStatusInformation = 0x9b,

        /// <summary>
        /// 0x95
        /// </summary>
        TerminalVerificationResults = 0x95,

        /// <summary>
        /// 0x8a
        /// </summary>
        AuthorisationResponseCode = 0x8a,

        /// <summary>
        /// 0x82
        /// </summary>
        ApplicationInterchangeProfile = 0x82,

        /// <summary>
        /// 0x84, XPI Moneris
        /// </summary>
        DedicatedFileName = 0x84,

        /// <summary>
        /// 0x4f
        /// </summary>
        ApplicationIdentifier = 0x4f,

        /// <summary>
        /// 0x57
        /// </summary>
        IccTrack2EquivData = 0x57,

        /// <summary>
        /// 0x50
        /// </summary>
        ApplicationLabel = 0x50,

        /// <summary>
        /// 0xdf01, XPI Moneris
        /// </summary>
        ReasonCodeOnline = 0xdf01,

        /// <summary>
        /// 0xdf04, XPI Moneris
        /// </summary>
        CardScheme = 0xdf04,

        /// <summary>
        /// 0xdf0e
        /// </summary>
        IccPublicKeyAndRemainder = 0xdf0e,

        /// <summary>
        /// 0xdf25
        /// </summary>
        ReasonOnlineCode = 0xdf25,

        /// <summary>
        /// 0xdf28. Firmware versions prior 2.3.2.1
        /// </summary>
        CardholderVerificationCompletedOld = 0xdf28,

        /// <summary>
        /// 0xdfdf28, Firmware versions 2.3.2.1 or greater
        /// </summary>
        CardholderVerificationCompleted = 0xdfdf28,

        /// <summary>
        /// 0xdf68
        /// </summary>
        DiagnosticCodes = 0xdf68,

        /// <summary>
        /// 0xdf7F
        /// </summary>
        Version = 0xdf7F,

        /// <summary>
        /// 0xdf8111
        /// </summary>
        BarcodeEncoding = 0xdf8111,

        /// <summary>
        /// 0xdf8113
        /// </summary>
        BarcodeScale = 0xdf8113,

        /// <summary>
        /// 0xdf8301
        /// </summary>
        AlphanumericString = 0xdf8301,

        /// <summary>
        /// 0xdfa201
        /// </summary>
        SecureLinkStatus = 0xdfa201,

        /// <summary>
        /// 0xdfa202
        /// </summary>
        OptionId = 0xdfa202,

        /// <summary>
        /// 0xdfa203
        /// </summary>
        OptionText = 0xdfa203,

        /// <summary>
        /// 0xdfa204
        /// </summary>
        ApplicationSelectionUsingPinPad = 0xdfa204,

        /// <summary>
        /// 0xdfa205
        /// </summary>
        KeyboardData = 0xdfa205,

        /// <summary>
        /// 0xdfa206
        /// </summary>
        LanguageIndex = 0xdfa206,

        /// <summary>
        /// 0xdfa207
        /// </summary>
        NumberFormat = 0xdfa207,

        /// <summary>
        /// 0xdfa208
        /// </summary>
        NumericString = 0xdfa208,

        /// <summary>
        /// 0xdfa209
        /// </summary>
        BatteryStatus = 0xdfa209,

        /// <summary>
        /// 0xdfa20a
        /// </summary>
        PinResult = 0xdfa20a,

        /// <summary>
        /// 0xdfa20e
        /// </summary>
        PinEntryTimeout = 0xdfa20e,

        /// <summary>
        /// 0xdfa20f
        /// </summary>
        BacklightMode = 0xdfa20f,

        /// <summary>
        /// 0xdfa210
        /// </summary>
        FontFileName = 0xdfa210,

        /// <summary>
        /// 0xdfa211
        /// </summary>
        MenuTitle = 0xdfa211,

        /// <summary>
        /// 0xdfa218
        /// </summary>
        PinEntryStyle = 0xdfa218,

        /// <summary>
        /// 0xdfa301
        /// </summary>
        BitmapFile = 0xdfa301,

        /// <summary>
        /// 0xdfa304
        /// </summary>
        BitmapCenter = 0xdfa304,

        /// <summary>
        /// 0xc4
        /// </summary>
        InformationDescription = 0xc4,

        /// <summary>
        /// 0x48
        /// </summary>
        CardMovement = 0x48,

        /// <summary>
        /// 0xc2, XPI Moneris specific tag
        /// </summary>
        XpiScript = 0xc2,

        /// <summary>
        /// 0xe2, XPI Moneris specific tag
        /// </summary>
        MinRequestObject = 0xe2,

        /// <summary>
        /// 0x91
        /// </summary>
        IssuerAuthenticationData = 0x91,

        /// <summary>
        /// 0x89
        /// </summary>
        AuthorisationCode = 0x89,

        /// <summary>
        /// 0x86
        /// </summary>
        IssuerScriptCommand = 0x86,

        /// <summary>
        /// OxDF02
        /// </summary>
        ChipConditionCode = 0xdf02,

        /// <summary>
        /// 0xdfed6c
        /// </summary>
        OnlinePinCipherBlock = 0xdfed6c,

        /// <summary>
        /// 0xdfed03
        /// </summary>
        Ksn = 0xdfed03,

        /// <summary>
        /// 0xdf62, ASF. Maybe a Moneris/XPI specific element. Required for when after insertion, the XPI response
        /// is 'Candidate List Empty'.
        /// </summary>
        ApplicationSelectionFlag = 0xdf62,

        /// <summary>
        /// 0xdfec30, On error (i.e. when SW1SW2 is different than 9000), this tag consists
        /// of error code, returned by Security Module
        /// </summary>
        ReturnCode = 0xdfec30,
    }
}