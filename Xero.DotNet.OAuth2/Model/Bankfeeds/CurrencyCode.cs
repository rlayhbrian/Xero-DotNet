/* 
 * Xero Bank Feeds API
 *
 * The Bank Feeds API is a closed API that is only available to financial institutions that have an established financial services partnership with Xero. If you're an existing financial services partner that wants access, contact your local Partner Manager. If you're a financial institution who wants to provide bank feeds to your business customers, contact us to become a financial services partner.
 *
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.DotNet.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.DotNet.OAuth2.Model.Bankfeeds
{
    /// <summary>
    /// 3 letter alpha code for the ISO-4217 currency code, e.g. USD, AUD.
    /// </summary>
    /// <value>3 letter alpha code for the ISO-4217 currency code, e.g. USD, AUD.</value>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum CurrencyCode
    {
        /// <summary>
        /// Enum AED for value: AED
        /// </summary>
        [EnumMember(Value = "AED")]
        AED = 1,

        /// <summary>
        /// Enum AFN for value: AFN
        /// </summary>
        [EnumMember(Value = "AFN")]
        AFN = 2,

        /// <summary>
        /// Enum ALL for value: ALL
        /// </summary>
        [EnumMember(Value = "ALL")]
        ALL = 3,

        /// <summary>
        /// Enum AMD for value: AMD
        /// </summary>
        [EnumMember(Value = "AMD")]
        AMD = 4,

        /// <summary>
        /// Enum ANG for value: ANG
        /// </summary>
        [EnumMember(Value = "ANG")]
        ANG = 5,

        /// <summary>
        /// Enum AOA for value: AOA
        /// </summary>
        [EnumMember(Value = "AOA")]
        AOA = 6,

        /// <summary>
        /// Enum ARS for value: ARS
        /// </summary>
        [EnumMember(Value = "ARS")]
        ARS = 7,

        /// <summary>
        /// Enum AUD for value: AUD
        /// </summary>
        [EnumMember(Value = "AUD")]
        AUD = 8,

        /// <summary>
        /// Enum AWG for value: AWG
        /// </summary>
        [EnumMember(Value = "AWG")]
        AWG = 9,

        /// <summary>
        /// Enum AZN for value: AZN
        /// </summary>
        [EnumMember(Value = "AZN")]
        AZN = 10,

        /// <summary>
        /// Enum BAM for value: BAM
        /// </summary>
        [EnumMember(Value = "BAM")]
        BAM = 11,

        /// <summary>
        /// Enum BBD for value: BBD
        /// </summary>
        [EnumMember(Value = "BBD")]
        BBD = 12,

        /// <summary>
        /// Enum BDT for value: BDT
        /// </summary>
        [EnumMember(Value = "BDT")]
        BDT = 13,

        /// <summary>
        /// Enum BGN for value: BGN
        /// </summary>
        [EnumMember(Value = "BGN")]
        BGN = 14,

        /// <summary>
        /// Enum BHD for value: BHD
        /// </summary>
        [EnumMember(Value = "BHD")]
        BHD = 15,

        /// <summary>
        /// Enum BIF for value: BIF
        /// </summary>
        [EnumMember(Value = "BIF")]
        BIF = 16,

        /// <summary>
        /// Enum BMD for value: BMD
        /// </summary>
        [EnumMember(Value = "BMD")]
        BMD = 17,

        /// <summary>
        /// Enum BND for value: BND
        /// </summary>
        [EnumMember(Value = "BND")]
        BND = 18,

        /// <summary>
        /// Enum BOB for value: BOB
        /// </summary>
        [EnumMember(Value = "BOB")]
        BOB = 19,

        /// <summary>
        /// Enum BRL for value: BRL
        /// </summary>
        [EnumMember(Value = "BRL")]
        BRL = 20,

        /// <summary>
        /// Enum BSD for value: BSD
        /// </summary>
        [EnumMember(Value = "BSD")]
        BSD = 21,

        /// <summary>
        /// Enum BTN for value: BTN
        /// </summary>
        [EnumMember(Value = "BTN")]
        BTN = 22,

        /// <summary>
        /// Enum BWP for value: BWP
        /// </summary>
        [EnumMember(Value = "BWP")]
        BWP = 23,

        /// <summary>
        /// Enum BYN for value: BYN
        /// </summary>
        [EnumMember(Value = "BYN")]
        BYN = 24,

        /// <summary>
        /// Enum BZD for value: BZD
        /// </summary>
        [EnumMember(Value = "BZD")]
        BZD = 25,

        /// <summary>
        /// Enum CAD for value: CAD
        /// </summary>
        [EnumMember(Value = "CAD")]
        CAD = 26,

        /// <summary>
        /// Enum CDF for value: CDF
        /// </summary>
        [EnumMember(Value = "CDF")]
        CDF = 27,

        /// <summary>
        /// Enum CHF for value: CHF
        /// </summary>
        [EnumMember(Value = "CHF")]
        CHF = 28,

        /// <summary>
        /// Enum CLP for value: CLP
        /// </summary>
        [EnumMember(Value = "CLP")]
        CLP = 29,

        /// <summary>
        /// Enum CNY for value: CNY
        /// </summary>
        [EnumMember(Value = "CNY")]
        CNY = 30,

        /// <summary>
        /// Enum COP for value: COP
        /// </summary>
        [EnumMember(Value = "COP")]
        COP = 31,

        /// <summary>
        /// Enum CRC for value: CRC
        /// </summary>
        [EnumMember(Value = "CRC")]
        CRC = 32,

        /// <summary>
        /// Enum CUC for value: CUC
        /// </summary>
        [EnumMember(Value = "CUC")]
        CUC = 33,

        /// <summary>
        /// Enum CUP for value: CUP
        /// </summary>
        [EnumMember(Value = "CUP")]
        CUP = 34,

        /// <summary>
        /// Enum CVE for value: CVE
        /// </summary>
        [EnumMember(Value = "CVE")]
        CVE = 35,

        /// <summary>
        /// Enum CZK for value: CZK
        /// </summary>
        [EnumMember(Value = "CZK")]
        CZK = 36,

        /// <summary>
        /// Enum DJF for value: DJF
        /// </summary>
        [EnumMember(Value = "DJF")]
        DJF = 37,

        /// <summary>
        /// Enum DKK for value: DKK
        /// </summary>
        [EnumMember(Value = "DKK")]
        DKK = 38,

        /// <summary>
        /// Enum DOP for value: DOP
        /// </summary>
        [EnumMember(Value = "DOP")]
        DOP = 39,

        /// <summary>
        /// Enum DZD for value: DZD
        /// </summary>
        [EnumMember(Value = "DZD")]
        DZD = 40,

        /// <summary>
        /// Enum EGP for value: EGP
        /// </summary>
        [EnumMember(Value = "EGP")]
        EGP = 41,

        /// <summary>
        /// Enum ERN for value: ERN
        /// </summary>
        [EnumMember(Value = "ERN")]
        ERN = 42,

        /// <summary>
        /// Enum ETB for value: ETB
        /// </summary>
        [EnumMember(Value = "ETB")]
        ETB = 43,

        /// <summary>
        /// Enum EUR for value: EUR
        /// </summary>
        [EnumMember(Value = "EUR")]
        EUR = 44,

        /// <summary>
        /// Enum FJD for value: FJD
        /// </summary>
        [EnumMember(Value = "FJD")]
        FJD = 45,

        /// <summary>
        /// Enum FKP for value: FKP
        /// </summary>
        [EnumMember(Value = "FKP")]
        FKP = 46,

        /// <summary>
        /// Enum GBP for value: GBP
        /// </summary>
        [EnumMember(Value = "GBP")]
        GBP = 47,

        /// <summary>
        /// Enum GEL for value: GEL
        /// </summary>
        [EnumMember(Value = "GEL")]
        GEL = 48,

        /// <summary>
        /// Enum GGP for value: GGP
        /// </summary>
        [EnumMember(Value = "GGP")]
        GGP = 49,

        /// <summary>
        /// Enum GHS for value: GHS
        /// </summary>
        [EnumMember(Value = "GHS")]
        GHS = 50,

        /// <summary>
        /// Enum GIP for value: GIP
        /// </summary>
        [EnumMember(Value = "GIP")]
        GIP = 51,

        /// <summary>
        /// Enum GMD for value: GMD
        /// </summary>
        [EnumMember(Value = "GMD")]
        GMD = 52,

        /// <summary>
        /// Enum GNF for value: GNF
        /// </summary>
        [EnumMember(Value = "GNF")]
        GNF = 53,

        /// <summary>
        /// Enum GTQ for value: GTQ
        /// </summary>
        [EnumMember(Value = "GTQ")]
        GTQ = 54,

        /// <summary>
        /// Enum GYD for value: GYD
        /// </summary>
        [EnumMember(Value = "GYD")]
        GYD = 55,

        /// <summary>
        /// Enum HKD for value: HKD
        /// </summary>
        [EnumMember(Value = "HKD")]
        HKD = 56,

        /// <summary>
        /// Enum HNL for value: HNL
        /// </summary>
        [EnumMember(Value = "HNL")]
        HNL = 57,

        /// <summary>
        /// Enum HRK for value: HRK
        /// </summary>
        [EnumMember(Value = "HRK")]
        HRK = 58,

        /// <summary>
        /// Enum HTG for value: HTG
        /// </summary>
        [EnumMember(Value = "HTG")]
        HTG = 59,

        /// <summary>
        /// Enum HUF for value: HUF
        /// </summary>
        [EnumMember(Value = "HUF")]
        HUF = 60,

        /// <summary>
        /// Enum IDR for value: IDR
        /// </summary>
        [EnumMember(Value = "IDR")]
        IDR = 61,

        /// <summary>
        /// Enum ILS for value: ILS
        /// </summary>
        [EnumMember(Value = "ILS")]
        ILS = 62,

        /// <summary>
        /// Enum IMP for value: IMP
        /// </summary>
        [EnumMember(Value = "IMP")]
        IMP = 63,

        /// <summary>
        /// Enum INR for value: INR
        /// </summary>
        [EnumMember(Value = "INR")]
        INR = 64,

        /// <summary>
        /// Enum IQD for value: IQD
        /// </summary>
        [EnumMember(Value = "IQD")]
        IQD = 65,

        /// <summary>
        /// Enum IRR for value: IRR
        /// </summary>
        [EnumMember(Value = "IRR")]
        IRR = 66,

        /// <summary>
        /// Enum ISK for value: ISK
        /// </summary>
        [EnumMember(Value = "ISK")]
        ISK = 67,

        /// <summary>
        /// Enum JEP for value: JEP
        /// </summary>
        [EnumMember(Value = "JEP")]
        JEP = 68,

        /// <summary>
        /// Enum JMD for value: JMD
        /// </summary>
        [EnumMember(Value = "JMD")]
        JMD = 69,

        /// <summary>
        /// Enum JOD for value: JOD
        /// </summary>
        [EnumMember(Value = "JOD")]
        JOD = 70,

        /// <summary>
        /// Enum JPY for value: JPY
        /// </summary>
        [EnumMember(Value = "JPY")]
        JPY = 71,

        /// <summary>
        /// Enum KES for value: KES
        /// </summary>
        [EnumMember(Value = "KES")]
        KES = 72,

        /// <summary>
        /// Enum KGS for value: KGS
        /// </summary>
        [EnumMember(Value = "KGS")]
        KGS = 73,

        /// <summary>
        /// Enum KHR for value: KHR
        /// </summary>
        [EnumMember(Value = "KHR")]
        KHR = 74,

        /// <summary>
        /// Enum KMF for value: KMF
        /// </summary>
        [EnumMember(Value = "KMF")]
        KMF = 75,

        /// <summary>
        /// Enum KPW for value: KPW
        /// </summary>
        [EnumMember(Value = "KPW")]
        KPW = 76,

        /// <summary>
        /// Enum KRW for value: KRW
        /// </summary>
        [EnumMember(Value = "KRW")]
        KRW = 77,

        /// <summary>
        /// Enum KWD for value: KWD
        /// </summary>
        [EnumMember(Value = "KWD")]
        KWD = 78,

        /// <summary>
        /// Enum KYD for value: KYD
        /// </summary>
        [EnumMember(Value = "KYD")]
        KYD = 79,

        /// <summary>
        /// Enum KZT for value: KZT
        /// </summary>
        [EnumMember(Value = "KZT")]
        KZT = 80,

        /// <summary>
        /// Enum LAK for value: LAK
        /// </summary>
        [EnumMember(Value = "LAK")]
        LAK = 81,

        /// <summary>
        /// Enum LBP for value: LBP
        /// </summary>
        [EnumMember(Value = "LBP")]
        LBP = 82,

        /// <summary>
        /// Enum LKR for value: LKR
        /// </summary>
        [EnumMember(Value = "LKR")]
        LKR = 83,

        /// <summary>
        /// Enum LRD for value: LRD
        /// </summary>
        [EnumMember(Value = "LRD")]
        LRD = 84,

        /// <summary>
        /// Enum LSL for value: LSL
        /// </summary>
        [EnumMember(Value = "LSL")]
        LSL = 85,

        /// <summary>
        /// Enum LYD for value: LYD
        /// </summary>
        [EnumMember(Value = "LYD")]
        LYD = 86,

        /// <summary>
        /// Enum MAD for value: MAD
        /// </summary>
        [EnumMember(Value = "MAD")]
        MAD = 87,

        /// <summary>
        /// Enum MDL for value: MDL
        /// </summary>
        [EnumMember(Value = "MDL")]
        MDL = 88,

        /// <summary>
        /// Enum MGA for value: MGA
        /// </summary>
        [EnumMember(Value = "MGA")]
        MGA = 89,

        /// <summary>
        /// Enum MKD for value: MKD
        /// </summary>
        [EnumMember(Value = "MKD")]
        MKD = 90,

        /// <summary>
        /// Enum MMK for value: MMK
        /// </summary>
        [EnumMember(Value = "MMK")]
        MMK = 91,

        /// <summary>
        /// Enum MNT for value: MNT
        /// </summary>
        [EnumMember(Value = "MNT")]
        MNT = 92,

        /// <summary>
        /// Enum MOP for value: MOP
        /// </summary>
        [EnumMember(Value = "MOP")]
        MOP = 93,

        /// <summary>
        /// Enum MRU for value: MRU
        /// </summary>
        [EnumMember(Value = "MRU")]
        MRU = 94,

        /// <summary>
        /// Enum MUR for value: MUR
        /// </summary>
        [EnumMember(Value = "MUR")]
        MUR = 95,

        /// <summary>
        /// Enum MVR for value: MVR
        /// </summary>
        [EnumMember(Value = "MVR")]
        MVR = 96,

        /// <summary>
        /// Enum MWK for value: MWK
        /// </summary>
        [EnumMember(Value = "MWK")]
        MWK = 97,

        /// <summary>
        /// Enum MXN for value: MXN
        /// </summary>
        [EnumMember(Value = "MXN")]
        MXN = 98,

        /// <summary>
        /// Enum MYR for value: MYR
        /// </summary>
        [EnumMember(Value = "MYR")]
        MYR = 99,

        /// <summary>
        /// Enum MZN for value: MZN
        /// </summary>
        [EnumMember(Value = "MZN")]
        MZN = 100,

        /// <summary>
        /// Enum NAD for value: NAD
        /// </summary>
        [EnumMember(Value = "NAD")]
        NAD = 101,

        /// <summary>
        /// Enum NGN for value: NGN
        /// </summary>
        [EnumMember(Value = "NGN")]
        NGN = 102,

        /// <summary>
        /// Enum NIO for value: NIO
        /// </summary>
        [EnumMember(Value = "NIO")]
        NIO = 103,

        /// <summary>
        /// Enum NOK for value: NOK
        /// </summary>
        [EnumMember(Value = "NOK")]
        NOK = 104,

        /// <summary>
        /// Enum NPR for value: NPR
        /// </summary>
        [EnumMember(Value = "NPR")]
        NPR = 105,

        /// <summary>
        /// Enum NZD for value: NZD
        /// </summary>
        [EnumMember(Value = "NZD")]
        NZD = 106,

        /// <summary>
        /// Enum OMR for value: OMR
        /// </summary>
        [EnumMember(Value = "OMR")]
        OMR = 107,

        /// <summary>
        /// Enum PAB for value: PAB
        /// </summary>
        [EnumMember(Value = "PAB")]
        PAB = 108,

        /// <summary>
        /// Enum PEN for value: PEN
        /// </summary>
        [EnumMember(Value = "PEN")]
        PEN = 109,

        /// <summary>
        /// Enum PGK for value: PGK
        /// </summary>
        [EnumMember(Value = "PGK")]
        PGK = 110,

        /// <summary>
        /// Enum PHP for value: PHP
        /// </summary>
        [EnumMember(Value = "PHP")]
        PHP = 111,

        /// <summary>
        /// Enum PKR for value: PKR
        /// </summary>
        [EnumMember(Value = "PKR")]
        PKR = 112,

        /// <summary>
        /// Enum PLN for value: PLN
        /// </summary>
        [EnumMember(Value = "PLN")]
        PLN = 113,

        /// <summary>
        /// Enum PYG for value: PYG
        /// </summary>
        [EnumMember(Value = "PYG")]
        PYG = 114,

        /// <summary>
        /// Enum QAR for value: QAR
        /// </summary>
        [EnumMember(Value = "QAR")]
        QAR = 115,

        /// <summary>
        /// Enum RON for value: RON
        /// </summary>
        [EnumMember(Value = "RON")]
        RON = 116,

        /// <summary>
        /// Enum RSD for value: RSD
        /// </summary>
        [EnumMember(Value = "RSD")]
        RSD = 117,

        /// <summary>
        /// Enum RUB for value: RUB
        /// </summary>
        [EnumMember(Value = "RUB")]
        RUB = 118,

        /// <summary>
        /// Enum RWF for value: RWF
        /// </summary>
        [EnumMember(Value = "RWF")]
        RWF = 119,

        /// <summary>
        /// Enum SAR for value: SAR
        /// </summary>
        [EnumMember(Value = "SAR")]
        SAR = 120,

        /// <summary>
        /// Enum SBD for value: SBD
        /// </summary>
        [EnumMember(Value = "SBD")]
        SBD = 121,

        /// <summary>
        /// Enum SCR for value: SCR
        /// </summary>
        [EnumMember(Value = "SCR")]
        SCR = 122,

        /// <summary>
        /// Enum SDG for value: SDG
        /// </summary>
        [EnumMember(Value = "SDG")]
        SDG = 123,

        /// <summary>
        /// Enum SEK for value: SEK
        /// </summary>
        [EnumMember(Value = "SEK")]
        SEK = 124,

        /// <summary>
        /// Enum SGD for value: SGD
        /// </summary>
        [EnumMember(Value = "SGD")]
        SGD = 125,

        /// <summary>
        /// Enum SHP for value: SHP
        /// </summary>
        [EnumMember(Value = "SHP")]
        SHP = 126,

        /// <summary>
        /// Enum SLL for value: SLL
        /// </summary>
        [EnumMember(Value = "SLL")]
        SLL = 127,

        /// <summary>
        /// Enum SOS for value: SOS
        /// </summary>
        [EnumMember(Value = "SOS")]
        SOS = 128,

        /// <summary>
        /// Enum SPL for value: SPL
        /// </summary>
        [EnumMember(Value = "SPL")]
        SPL = 129,

        /// <summary>
        /// Enum SRD for value: SRD
        /// </summary>
        [EnumMember(Value = "SRD")]
        SRD = 130,

        /// <summary>
        /// Enum STN for value: STN
        /// </summary>
        [EnumMember(Value = "STN")]
        STN = 131,

        /// <summary>
        /// Enum SVC for value: SVC
        /// </summary>
        [EnumMember(Value = "SVC")]
        SVC = 132,

        /// <summary>
        /// Enum SYP for value: SYP
        /// </summary>
        [EnumMember(Value = "SYP")]
        SYP = 133,

        /// <summary>
        /// Enum SZL for value: SZL
        /// </summary>
        [EnumMember(Value = "SZL")]
        SZL = 134,

        /// <summary>
        /// Enum THB for value: THB
        /// </summary>
        [EnumMember(Value = "THB")]
        THB = 135,

        /// <summary>
        /// Enum TJS for value: TJS
        /// </summary>
        [EnumMember(Value = "TJS")]
        TJS = 136,

        /// <summary>
        /// Enum TMT for value: TMT
        /// </summary>
        [EnumMember(Value = "TMT")]
        TMT = 137,

        /// <summary>
        /// Enum TND for value: TND
        /// </summary>
        [EnumMember(Value = "TND")]
        TND = 138,

        /// <summary>
        /// Enum TOP for value: TOP
        /// </summary>
        [EnumMember(Value = "TOP")]
        TOP = 139,

        /// <summary>
        /// Enum TRY for value: TRY
        /// </summary>
        [EnumMember(Value = "TRY")]
        TRY = 140,

        /// <summary>
        /// Enum TTD for value: TTD
        /// </summary>
        [EnumMember(Value = "TTD")]
        TTD = 141,

        /// <summary>
        /// Enum TVD for value: TVD
        /// </summary>
        [EnumMember(Value = "TVD")]
        TVD = 142,

        /// <summary>
        /// Enum TWD for value: TWD
        /// </summary>
        [EnumMember(Value = "TWD")]
        TWD = 143,

        /// <summary>
        /// Enum TZS for value: TZS
        /// </summary>
        [EnumMember(Value = "TZS")]
        TZS = 144,

        /// <summary>
        /// Enum UAH for value: UAH
        /// </summary>
        [EnumMember(Value = "UAH")]
        UAH = 145,

        /// <summary>
        /// Enum UGX for value: UGX
        /// </summary>
        [EnumMember(Value = "UGX")]
        UGX = 146,

        /// <summary>
        /// Enum USD for value: USD
        /// </summary>
        [EnumMember(Value = "USD")]
        USD = 147,

        /// <summary>
        /// Enum UYU for value: UYU
        /// </summary>
        [EnumMember(Value = "UYU")]
        UYU = 148,

        /// <summary>
        /// Enum UZS for value: UZS
        /// </summary>
        [EnumMember(Value = "UZS")]
        UZS = 149,

        /// <summary>
        /// Enum VEF for value: VEF
        /// </summary>
        [EnumMember(Value = "VEF")]
        VEF = 150,

        /// <summary>
        /// Enum VND for value: VND
        /// </summary>
        [EnumMember(Value = "VND")]
        VND = 151,

        /// <summary>
        /// Enum VUV for value: VUV
        /// </summary>
        [EnumMember(Value = "VUV")]
        VUV = 152,

        /// <summary>
        /// Enum WST for value: WST
        /// </summary>
        [EnumMember(Value = "WST")]
        WST = 153,

        /// <summary>
        /// Enum XAF for value: XAF
        /// </summary>
        [EnumMember(Value = "XAF")]
        XAF = 154,

        /// <summary>
        /// Enum XCD for value: XCD
        /// </summary>
        [EnumMember(Value = "XCD")]
        XCD = 155,

        /// <summary>
        /// Enum XDR for value: XDR
        /// </summary>
        [EnumMember(Value = "XDR")]
        XDR = 156,

        /// <summary>
        /// Enum XOF for value: XOF
        /// </summary>
        [EnumMember(Value = "XOF")]
        XOF = 157,

        /// <summary>
        /// Enum XPF for value: XPF
        /// </summary>
        [EnumMember(Value = "XPF")]
        XPF = 158,

        /// <summary>
        /// Enum YER for value: YER
        /// </summary>
        [EnumMember(Value = "YER")]
        YER = 159,

        /// <summary>
        /// Enum ZAR for value: ZAR
        /// </summary>
        [EnumMember(Value = "ZAR")]
        ZAR = 160,

        /// <summary>
        /// Enum ZMW for value: ZMW
        /// </summary>
        [EnumMember(Value = "ZMW")]
        ZMW = 161,

        /// <summary>
        /// Enum ZMK for value: ZMK
        /// </summary>
        [EnumMember(Value = "ZMK")]
        ZMK = 162,

        /// <summary>
        /// Enum ZWD for value: ZWD
        /// </summary>
        [EnumMember(Value = "ZWD")]
        ZWD = 163

    }

}
