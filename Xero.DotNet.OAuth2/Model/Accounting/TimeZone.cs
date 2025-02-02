/* 
 * Xero Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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

namespace Xero.DotNet.OAuth2.Model.Accounting
{
    /// <summary>
    /// Timezone specifications
    /// </summary>
    /// <value>Timezone specifications</value>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum TimeZone
    {
        /// <summary>
        /// Enum AFGHANISTANSTANDARDTIME for value: AFGHANISTANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "AFGHANISTANSTANDARDTIME")]
        AFGHANISTANSTANDARDTIME = 1,

        /// <summary>
        /// Enum ALASKANSTANDARDTIME for value: ALASKANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ALASKANSTANDARDTIME")]
        ALASKANSTANDARDTIME = 2,

        /// <summary>
        /// Enum ALEUTIANSTANDARDTIME for value: ALEUTIANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ALEUTIANSTANDARDTIME")]
        ALEUTIANSTANDARDTIME = 3,

        /// <summary>
        /// Enum ALTAISTANDARDTIME for value: ALTAISTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ALTAISTANDARDTIME")]
        ALTAISTANDARDTIME = 4,

        /// <summary>
        /// Enum ARABIANSTANDARDTIME for value: ARABIANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ARABIANSTANDARDTIME")]
        ARABIANSTANDARDTIME = 5,

        /// <summary>
        /// Enum ARABICSTANDARDTIME for value: ARABICSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ARABICSTANDARDTIME")]
        ARABICSTANDARDTIME = 6,

        /// <summary>
        /// Enum ARABSTANDARDTIME for value: ARABSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ARABSTANDARDTIME")]
        ARABSTANDARDTIME = 7,

        /// <summary>
        /// Enum ARGENTINASTANDARDTIME for value: ARGENTINASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ARGENTINASTANDARDTIME")]
        ARGENTINASTANDARDTIME = 8,

        /// <summary>
        /// Enum ASTRAKHANSTANDARDTIME for value: ASTRAKHANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ASTRAKHANSTANDARDTIME")]
        ASTRAKHANSTANDARDTIME = 9,

        /// <summary>
        /// Enum ATLANTICSTANDARDTIME for value: ATLANTICSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ATLANTICSTANDARDTIME")]
        ATLANTICSTANDARDTIME = 10,

        /// <summary>
        /// Enum AUSCENTRALSTANDARDTIME for value: AUSCENTRALSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "AUSCENTRALSTANDARDTIME")]
        AUSCENTRALSTANDARDTIME = 11,

        /// <summary>
        /// Enum AUSCENTRALWSTANDARDTIME for value: AUSCENTRALWSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "AUSCENTRALWSTANDARDTIME")]
        AUSCENTRALWSTANDARDTIME = 12,

        /// <summary>
        /// Enum AUSEASTERNSTANDARDTIME for value: AUSEASTERNSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "AUSEASTERNSTANDARDTIME")]
        AUSEASTERNSTANDARDTIME = 13,

        /// <summary>
        /// Enum AZERBAIJANSTANDARDTIME for value: AZERBAIJANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "AZERBAIJANSTANDARDTIME")]
        AZERBAIJANSTANDARDTIME = 14,

        /// <summary>
        /// Enum AZORESSTANDARDTIME for value: AZORESSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "AZORESSTANDARDTIME")]
        AZORESSTANDARDTIME = 15,

        /// <summary>
        /// Enum BAHIASTANDARDTIME for value: BAHIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "BAHIASTANDARDTIME")]
        BAHIASTANDARDTIME = 16,

        /// <summary>
        /// Enum BANGLADESHSTANDARDTIME for value: BANGLADESHSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "BANGLADESHSTANDARDTIME")]
        BANGLADESHSTANDARDTIME = 17,

        /// <summary>
        /// Enum BELARUSSTANDARDTIME for value: BELARUSSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "BELARUSSTANDARDTIME")]
        BELARUSSTANDARDTIME = 18,

        /// <summary>
        /// Enum BOUGAINVILLESTANDARDTIME for value: BOUGAINVILLESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "BOUGAINVILLESTANDARDTIME")]
        BOUGAINVILLESTANDARDTIME = 19,

        /// <summary>
        /// Enum CANADACENTRALSTANDARDTIME for value: CANADACENTRALSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CANADACENTRALSTANDARDTIME")]
        CANADACENTRALSTANDARDTIME = 20,

        /// <summary>
        /// Enum CAPEVERDESTANDARDTIME for value: CAPEVERDESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CAPEVERDESTANDARDTIME")]
        CAPEVERDESTANDARDTIME = 21,

        /// <summary>
        /// Enum CAUCASUSSTANDARDTIME for value: CAUCASUSSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CAUCASUSSTANDARDTIME")]
        CAUCASUSSTANDARDTIME = 22,

        /// <summary>
        /// Enum CENAUSTRALIASTANDARDTIME for value: CENAUSTRALIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENAUSTRALIASTANDARDTIME")]
        CENAUSTRALIASTANDARDTIME = 23,

        /// <summary>
        /// Enum CENTRALAMERICASTANDARDTIME for value: CENTRALAMERICASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENTRALAMERICASTANDARDTIME")]
        CENTRALAMERICASTANDARDTIME = 24,

        /// <summary>
        /// Enum CENTRALASIASTANDARDTIME for value: CENTRALASIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENTRALASIASTANDARDTIME")]
        CENTRALASIASTANDARDTIME = 25,

        /// <summary>
        /// Enum CENTRALBRAZILIANSTANDARDTIME for value: CENTRALBRAZILIANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENTRALBRAZILIANSTANDARDTIME")]
        CENTRALBRAZILIANSTANDARDTIME = 26,

        /// <summary>
        /// Enum CENTRALEUROPEANSTANDARDTIME for value: CENTRALEUROPEANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENTRALEUROPEANSTANDARDTIME")]
        CENTRALEUROPEANSTANDARDTIME = 27,

        /// <summary>
        /// Enum CENTRALEUROPESTANDARDTIME for value: CENTRALEUROPESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENTRALEUROPESTANDARDTIME")]
        CENTRALEUROPESTANDARDTIME = 28,

        /// <summary>
        /// Enum CENTRALPACIFICSTANDARDTIME for value: CENTRALPACIFICSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENTRALPACIFICSTANDARDTIME")]
        CENTRALPACIFICSTANDARDTIME = 29,

        /// <summary>
        /// Enum CENTRALSTANDARDTIME for value: CENTRALSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENTRALSTANDARDTIME")]
        CENTRALSTANDARDTIME = 30,

        /// <summary>
        /// Enum CENTRALSTANDARDTIMEMEXICO for value: CENTRALSTANDARDTIME(MEXICO)
        /// </summary>
        [EnumMember(Value = "CENTRALSTANDARDTIME(MEXICO)")]
        CENTRALSTANDARDTIMEMEXICO = 31,

        /// <summary>
        /// Enum CHATHAMISLANDSSTANDARDTIME for value: CHATHAMISLANDSSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CHATHAMISLANDSSTANDARDTIME")]
        CHATHAMISLANDSSTANDARDTIME = 32,

        /// <summary>
        /// Enum CHINASTANDARDTIME for value: CHINASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CHINASTANDARDTIME")]
        CHINASTANDARDTIME = 33,

        /// <summary>
        /// Enum CUBASTANDARDTIME for value: CUBASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CUBASTANDARDTIME")]
        CUBASTANDARDTIME = 34,

        /// <summary>
        /// Enum DATELINESTANDARDTIME for value: DATELINESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "DATELINESTANDARDTIME")]
        DATELINESTANDARDTIME = 35,

        /// <summary>
        /// Enum EAFRICASTANDARDTIME for value: EAFRICASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "EAFRICASTANDARDTIME")]
        EAFRICASTANDARDTIME = 36,

        /// <summary>
        /// Enum EASTERISLANDSTANDARDTIME for value: EASTERISLANDSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "EASTERISLANDSTANDARDTIME")]
        EASTERISLANDSTANDARDTIME = 37,

        /// <summary>
        /// Enum EASTERNSTANDARDTIME for value: EASTERNSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "EASTERNSTANDARDTIME")]
        EASTERNSTANDARDTIME = 38,

        /// <summary>
        /// Enum EASTERNSTANDARDTIMEMEXICO for value: EASTERNSTANDARDTIME(MEXICO)
        /// </summary>
        [EnumMember(Value = "EASTERNSTANDARDTIME(MEXICO)")]
        EASTERNSTANDARDTIMEMEXICO = 39,

        /// <summary>
        /// Enum EAUSTRALIASTANDARDTIME for value: EAUSTRALIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "EAUSTRALIASTANDARDTIME")]
        EAUSTRALIASTANDARDTIME = 40,

        /// <summary>
        /// Enum EEUROPESTANDARDTIME for value: EEUROPESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "EEUROPESTANDARDTIME")]
        EEUROPESTANDARDTIME = 41,

        /// <summary>
        /// Enum EGYPTSTANDARDTIME for value: EGYPTSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "EGYPTSTANDARDTIME")]
        EGYPTSTANDARDTIME = 42,

        /// <summary>
        /// Enum EKATERINBURGSTANDARDTIME for value: EKATERINBURGSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "EKATERINBURGSTANDARDTIME")]
        EKATERINBURGSTANDARDTIME = 43,

        /// <summary>
        /// Enum ESOUTHAMERICASTANDARDTIME for value: ESOUTHAMERICASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ESOUTHAMERICASTANDARDTIME")]
        ESOUTHAMERICASTANDARDTIME = 44,

        /// <summary>
        /// Enum FIJISTANDARDTIME for value: FIJISTANDARDTIME
        /// </summary>
        [EnumMember(Value = "FIJISTANDARDTIME")]
        FIJISTANDARDTIME = 45,

        /// <summary>
        /// Enum FLESTANDARDTIME for value: FLESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "FLESTANDARDTIME")]
        FLESTANDARDTIME = 46,

        /// <summary>
        /// Enum GEORGIANSTANDARDTIME for value: GEORGIANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "GEORGIANSTANDARDTIME")]
        GEORGIANSTANDARDTIME = 47,

        /// <summary>
        /// Enum GMTSTANDARDTIME for value: GMTSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "GMTSTANDARDTIME")]
        GMTSTANDARDTIME = 48,

        /// <summary>
        /// Enum GREENLANDSTANDARDTIME for value: GREENLANDSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "GREENLANDSTANDARDTIME")]
        GREENLANDSTANDARDTIME = 49,

        /// <summary>
        /// Enum GREENWICHSTANDARDTIME for value: GREENWICHSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "GREENWICHSTANDARDTIME")]
        GREENWICHSTANDARDTIME = 50,

        /// <summary>
        /// Enum GTBSTANDARDTIME for value: GTBSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "GTBSTANDARDTIME")]
        GTBSTANDARDTIME = 51,

        /// <summary>
        /// Enum HAITISTANDARDTIME for value: HAITISTANDARDTIME
        /// </summary>
        [EnumMember(Value = "HAITISTANDARDTIME")]
        HAITISTANDARDTIME = 52,

        /// <summary>
        /// Enum HAWAIIANSTANDARDTIME for value: HAWAIIANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "HAWAIIANSTANDARDTIME")]
        HAWAIIANSTANDARDTIME = 53,

        /// <summary>
        /// Enum INDIASTANDARDTIME for value: INDIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "INDIASTANDARDTIME")]
        INDIASTANDARDTIME = 54,

        /// <summary>
        /// Enum IRANSTANDARDTIME for value: IRANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "IRANSTANDARDTIME")]
        IRANSTANDARDTIME = 55,

        /// <summary>
        /// Enum ISRAELSTANDARDTIME for value: ISRAELSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ISRAELSTANDARDTIME")]
        ISRAELSTANDARDTIME = 56,

        /// <summary>
        /// Enum JORDANSTANDARDTIME for value: JORDANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "JORDANSTANDARDTIME")]
        JORDANSTANDARDTIME = 57,

        /// <summary>
        /// Enum KALININGRADSTANDARDTIME for value: KALININGRADSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "KALININGRADSTANDARDTIME")]
        KALININGRADSTANDARDTIME = 58,

        /// <summary>
        /// Enum KAMCHATKASTANDARDTIME for value: KAMCHATKASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "KAMCHATKASTANDARDTIME")]
        KAMCHATKASTANDARDTIME = 59,

        /// <summary>
        /// Enum KOREASTANDARDTIME for value: KOREASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "KOREASTANDARDTIME")]
        KOREASTANDARDTIME = 60,

        /// <summary>
        /// Enum LIBYASTANDARDTIME for value: LIBYASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "LIBYASTANDARDTIME")]
        LIBYASTANDARDTIME = 61,

        /// <summary>
        /// Enum LINEISLANDSSTANDARDTIME for value: LINEISLANDSSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "LINEISLANDSSTANDARDTIME")]
        LINEISLANDSSTANDARDTIME = 62,

        /// <summary>
        /// Enum LORDHOWESTANDARDTIME for value: LORDHOWESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "LORDHOWESTANDARDTIME")]
        LORDHOWESTANDARDTIME = 63,

        /// <summary>
        /// Enum MAGADANSTANDARDTIME for value: MAGADANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MAGADANSTANDARDTIME")]
        MAGADANSTANDARDTIME = 64,

        /// <summary>
        /// Enum MAGALLANESSTANDARDTIME for value: MAGALLANESSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MAGALLANESSTANDARDTIME")]
        MAGALLANESSTANDARDTIME = 65,

        /// <summary>
        /// Enum MARQUESASSTANDARDTIME for value: MARQUESASSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MARQUESASSTANDARDTIME")]
        MARQUESASSTANDARDTIME = 66,

        /// <summary>
        /// Enum MAURITIUSSTANDARDTIME for value: MAURITIUSSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MAURITIUSSTANDARDTIME")]
        MAURITIUSSTANDARDTIME = 67,

        /// <summary>
        /// Enum MIDATLANTICSTANDARDTIME for value: MIDATLANTICSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MIDATLANTICSTANDARDTIME")]
        MIDATLANTICSTANDARDTIME = 68,

        /// <summary>
        /// Enum MIDDLEEASTSTANDARDTIME for value: MIDDLEEASTSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MIDDLEEASTSTANDARDTIME")]
        MIDDLEEASTSTANDARDTIME = 69,

        /// <summary>
        /// Enum MONTEVIDEOSTANDARDTIME for value: MONTEVIDEOSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MONTEVIDEOSTANDARDTIME")]
        MONTEVIDEOSTANDARDTIME = 70,

        /// <summary>
        /// Enum MOROCCOSTANDARDTIME for value: MOROCCOSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MOROCCOSTANDARDTIME")]
        MOROCCOSTANDARDTIME = 71,

        /// <summary>
        /// Enum MOUNTAINSTANDARDTIME for value: MOUNTAINSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MOUNTAINSTANDARDTIME")]
        MOUNTAINSTANDARDTIME = 72,

        /// <summary>
        /// Enum MOUNTAINSTANDARDTIMEMEXICO for value: MOUNTAINSTANDARDTIME(MEXICO)
        /// </summary>
        [EnumMember(Value = "MOUNTAINSTANDARDTIME(MEXICO)")]
        MOUNTAINSTANDARDTIMEMEXICO = 73,

        /// <summary>
        /// Enum MYANMARSTANDARDTIME for value: MYANMARSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MYANMARSTANDARDTIME")]
        MYANMARSTANDARDTIME = 74,

        /// <summary>
        /// Enum NAMIBIASTANDARDTIME for value: NAMIBIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NAMIBIASTANDARDTIME")]
        NAMIBIASTANDARDTIME = 75,

        /// <summary>
        /// Enum NCENTRALASIASTANDARDTIME for value: NCENTRALASIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NCENTRALASIASTANDARDTIME")]
        NCENTRALASIASTANDARDTIME = 76,

        /// <summary>
        /// Enum NEPALSTANDARDTIME for value: NEPALSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NEPALSTANDARDTIME")]
        NEPALSTANDARDTIME = 77,

        /// <summary>
        /// Enum NEWFOUNDLANDSTANDARDTIME for value: NEWFOUNDLANDSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NEWFOUNDLANDSTANDARDTIME")]
        NEWFOUNDLANDSTANDARDTIME = 78,

        /// <summary>
        /// Enum NEWZEALANDSTANDARDTIME for value: NEWZEALANDSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NEWZEALANDSTANDARDTIME")]
        NEWZEALANDSTANDARDTIME = 79,

        /// <summary>
        /// Enum NORFOLKSTANDARDTIME for value: NORFOLKSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NORFOLKSTANDARDTIME")]
        NORFOLKSTANDARDTIME = 80,

        /// <summary>
        /// Enum NORTHASIAEASTSTANDARDTIME for value: NORTHASIAEASTSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NORTHASIAEASTSTANDARDTIME")]
        NORTHASIAEASTSTANDARDTIME = 81,

        /// <summary>
        /// Enum NORTHASIASTANDARDTIME for value: NORTHASIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NORTHASIASTANDARDTIME")]
        NORTHASIASTANDARDTIME = 82,

        /// <summary>
        /// Enum NORTHKOREASTANDARDTIME for value: NORTHKOREASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NORTHKOREASTANDARDTIME")]
        NORTHKOREASTANDARDTIME = 83,

        /// <summary>
        /// Enum OMSKSTANDARDTIME for value: OMSKSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "OMSKSTANDARDTIME")]
        OMSKSTANDARDTIME = 84,

        /// <summary>
        /// Enum PACIFICSASTANDARDTIME for value: PACIFICSASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "PACIFICSASTANDARDTIME")]
        PACIFICSASTANDARDTIME = 85,

        /// <summary>
        /// Enum PACIFICSTANDARDTIME for value: PACIFICSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "PACIFICSTANDARDTIME")]
        PACIFICSTANDARDTIME = 86,

        /// <summary>
        /// Enum PACIFICSTANDARDTIMEMEXICO for value: PACIFICSTANDARDTIME(MEXICO)
        /// </summary>
        [EnumMember(Value = "PACIFICSTANDARDTIME(MEXICO)")]
        PACIFICSTANDARDTIMEMEXICO = 87,

        /// <summary>
        /// Enum PAKISTANSTANDARDTIME for value: PAKISTANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "PAKISTANSTANDARDTIME")]
        PAKISTANSTANDARDTIME = 88,

        /// <summary>
        /// Enum PARAGUAYSTANDARDTIME for value: PARAGUAYSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "PARAGUAYSTANDARDTIME")]
        PARAGUAYSTANDARDTIME = 89,

        /// <summary>
        /// Enum QYZYLORDASTANDARDTIME for value: QYZYLORDASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "QYZYLORDASTANDARDTIME")]
        QYZYLORDASTANDARDTIME = 90,

        /// <summary>
        /// Enum ROMANCESTANDARDTIME for value: ROMANCESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ROMANCESTANDARDTIME")]
        ROMANCESTANDARDTIME = 91,

        /// <summary>
        /// Enum RUSSIANSTANDARDTIME for value: RUSSIANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "RUSSIANSTANDARDTIME")]
        RUSSIANSTANDARDTIME = 92,

        /// <summary>
        /// Enum RUSSIATIMEZONE10 for value: RUSSIATIMEZONE10
        /// </summary>
        [EnumMember(Value = "RUSSIATIMEZONE10")]
        RUSSIATIMEZONE10 = 93,

        /// <summary>
        /// Enum RUSSIATIMEZONE11 for value: RUSSIATIMEZONE11
        /// </summary>
        [EnumMember(Value = "RUSSIATIMEZONE11")]
        RUSSIATIMEZONE11 = 94,

        /// <summary>
        /// Enum RUSSIATIMEZONE3 for value: RUSSIATIMEZONE3
        /// </summary>
        [EnumMember(Value = "RUSSIATIMEZONE3")]
        RUSSIATIMEZONE3 = 95,

        /// <summary>
        /// Enum SAEASTERNSTANDARDTIME for value: SAEASTERNSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SAEASTERNSTANDARDTIME")]
        SAEASTERNSTANDARDTIME = 96,

        /// <summary>
        /// Enum SAINTPIERRESTANDARDTIME for value: SAINTPIERRESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SAINTPIERRESTANDARDTIME")]
        SAINTPIERRESTANDARDTIME = 97,

        /// <summary>
        /// Enum SAKHALINSTANDARDTIME for value: SAKHALINSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SAKHALINSTANDARDTIME")]
        SAKHALINSTANDARDTIME = 98,

        /// <summary>
        /// Enum SAMOASTANDARDTIME for value: SAMOASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SAMOASTANDARDTIME")]
        SAMOASTANDARDTIME = 99,

        /// <summary>
        /// Enum SAOTOMESTANDARDTIME for value: SAOTOMESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SAOTOMESTANDARDTIME")]
        SAOTOMESTANDARDTIME = 100,

        /// <summary>
        /// Enum SAPACIFICSTANDARDTIME for value: SAPACIFICSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SAPACIFICSTANDARDTIME")]
        SAPACIFICSTANDARDTIME = 101,

        /// <summary>
        /// Enum SARATOVSTANDARDTIME for value: SARATOVSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SARATOVSTANDARDTIME")]
        SARATOVSTANDARDTIME = 102,

        /// <summary>
        /// Enum SAWESTERNSTANDARDTIME for value: SAWESTERNSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SAWESTERNSTANDARDTIME")]
        SAWESTERNSTANDARDTIME = 103,

        /// <summary>
        /// Enum SEASIASTANDARDTIME for value: SEASIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SEASIASTANDARDTIME")]
        SEASIASTANDARDTIME = 104,

        /// <summary>
        /// Enum SINGAPORESTANDARDTIME for value: SINGAPORESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SINGAPORESTANDARDTIME")]
        SINGAPORESTANDARDTIME = 105,

        /// <summary>
        /// Enum SOUTHAFRICASTANDARDTIME for value: SOUTHAFRICASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SOUTHAFRICASTANDARDTIME")]
        SOUTHAFRICASTANDARDTIME = 106,

        /// <summary>
        /// Enum SOUTHSUDANSTANDARDTIME for value: SOUTHSUDANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SOUTHSUDANSTANDARDTIME")]
        SOUTHSUDANSTANDARDTIME = 107,

        /// <summary>
        /// Enum SRILANKASTANDARDTIME for value: SRILANKASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SRILANKASTANDARDTIME")]
        SRILANKASTANDARDTIME = 108,

        /// <summary>
        /// Enum SUDANSTANDARDTIME for value: SUDANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SUDANSTANDARDTIME")]
        SUDANSTANDARDTIME = 109,

        /// <summary>
        /// Enum SYRIASTANDARDTIME for value: SYRIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SYRIASTANDARDTIME")]
        SYRIASTANDARDTIME = 110,

        /// <summary>
        /// Enum TAIPEISTANDARDTIME for value: TAIPEISTANDARDTIME
        /// </summary>
        [EnumMember(Value = "TAIPEISTANDARDTIME")]
        TAIPEISTANDARDTIME = 111,

        /// <summary>
        /// Enum TASMANIASTANDARDTIME for value: TASMANIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "TASMANIASTANDARDTIME")]
        TASMANIASTANDARDTIME = 112,

        /// <summary>
        /// Enum TOCANTINSSTANDARDTIME for value: TOCANTINSSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "TOCANTINSSTANDARDTIME")]
        TOCANTINSSTANDARDTIME = 113,

        /// <summary>
        /// Enum TOKYOSTANDARDTIME for value: TOKYOSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "TOKYOSTANDARDTIME")]
        TOKYOSTANDARDTIME = 114,

        /// <summary>
        /// Enum TOMSKSTANDARDTIME for value: TOMSKSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "TOMSKSTANDARDTIME")]
        TOMSKSTANDARDTIME = 115,

        /// <summary>
        /// Enum TONGASTANDARDTIME for value: TONGASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "TONGASTANDARDTIME")]
        TONGASTANDARDTIME = 116,

        /// <summary>
        /// Enum TRANSBAIKALSTANDARDTIME for value: TRANSBAIKALSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "TRANSBAIKALSTANDARDTIME")]
        TRANSBAIKALSTANDARDTIME = 117,

        /// <summary>
        /// Enum TURKEYSTANDARDTIME for value: TURKEYSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "TURKEYSTANDARDTIME")]
        TURKEYSTANDARDTIME = 118,

        /// <summary>
        /// Enum TURKSANDCAICOSSTANDARDTIME for value: TURKSANDCAICOSSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "TURKSANDCAICOSSTANDARDTIME")]
        TURKSANDCAICOSSTANDARDTIME = 119,

        /// <summary>
        /// Enum ULAANBAATARSTANDARDTIME for value: ULAANBAATARSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ULAANBAATARSTANDARDTIME")]
        ULAANBAATARSTANDARDTIME = 120,

        /// <summary>
        /// Enum USEASTERNSTANDARDTIME for value: USEASTERNSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "USEASTERNSTANDARDTIME")]
        USEASTERNSTANDARDTIME = 121,

        /// <summary>
        /// Enum USMOUNTAINSTANDARDTIME for value: USMOUNTAINSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "USMOUNTAINSTANDARDTIME")]
        USMOUNTAINSTANDARDTIME = 122,

        /// <summary>
        /// Enum UTC for value: UTC
        /// </summary>
        [EnumMember(Value = "UTC")]
        UTC = 123,

        /// <summary>
        /// Enum UTC12 for value: UTC+12
        /// </summary>
        [EnumMember(Value = "UTC+12")]
        UTC12 = 124,

        /// <summary>
        /// Enum UTC13 for value: UTC+13
        /// </summary>
        [EnumMember(Value = "UTC+13")]
        UTC13 = 125,

        /// <summary>
        /// Enum UTC02 for value: UTC02
        /// </summary>
        [EnumMember(Value = "UTC02")]
        UTC02 = 126,

        /// <summary>
        /// Enum UTC08 for value: UTC08
        /// </summary>
        [EnumMember(Value = "UTC08")]
        UTC08 = 127,

        /// <summary>
        /// Enum UTC09 for value: UTC09
        /// </summary>
        [EnumMember(Value = "UTC09")]
        UTC09 = 128,

        /// <summary>
        /// Enum UTC11 for value: UTC11
        /// </summary>
        [EnumMember(Value = "UTC11")]
        UTC11 = 129,

        /// <summary>
        /// Enum VENEZUELASTANDARDTIME for value: VENEZUELASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "VENEZUELASTANDARDTIME")]
        VENEZUELASTANDARDTIME = 130,

        /// <summary>
        /// Enum VLADIVOSTOKSTANDARDTIME for value: VLADIVOSTOKSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "VLADIVOSTOKSTANDARDTIME")]
        VLADIVOSTOKSTANDARDTIME = 131,

        /// <summary>
        /// Enum VOLGOGRADSTANDARDTIME for value: VOLGOGRADSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "VOLGOGRADSTANDARDTIME")]
        VOLGOGRADSTANDARDTIME = 132,

        /// <summary>
        /// Enum WAUSTRALIASTANDARDTIME for value: WAUSTRALIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "WAUSTRALIASTANDARDTIME")]
        WAUSTRALIASTANDARDTIME = 133,

        /// <summary>
        /// Enum WCENTRALAFRICASTANDARDTIME for value: WCENTRALAFRICASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "WCENTRALAFRICASTANDARDTIME")]
        WCENTRALAFRICASTANDARDTIME = 134,

        /// <summary>
        /// Enum WESTASIASTANDARDTIME for value: WESTASIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "WESTASIASTANDARDTIME")]
        WESTASIASTANDARDTIME = 135,

        /// <summary>
        /// Enum WESTBANKSTANDARDTIME for value: WESTBANKSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "WESTBANKSTANDARDTIME")]
        WESTBANKSTANDARDTIME = 136,

        /// <summary>
        /// Enum WESTPACIFICSTANDARDTIME for value: WESTPACIFICSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "WESTPACIFICSTANDARDTIME")]
        WESTPACIFICSTANDARDTIME = 137,

        /// <summary>
        /// Enum WEUROPESTANDARDTIME for value: WEUROPESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "WEUROPESTANDARDTIME")]
        WEUROPESTANDARDTIME = 138,

        /// <summary>
        /// Enum WMONGOLIASTANDARDTIME for value: WMONGOLIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "WMONGOLIASTANDARDTIME")]
        WMONGOLIASTANDARDTIME = 139,

        /// <summary>
        /// Enum YAKUTSKSTANDARDTIME for value: YAKUTSKSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "YAKUTSKSTANDARDTIME")]
        YAKUTSKSTANDARDTIME = 140,

        /// <summary>
        /// Enum YUKONSTANDARDTIME for value: YUKONSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "YUKONSTANDARDTIME")]
        YUKONSTANDARDTIME = 141

    }

}
