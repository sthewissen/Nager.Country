using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Tuvalu
    /// </summary>
    public class TuvaluInfo : ICountryInfo
    {
        public string CommonName => "Tuvalu";
        public string OfficialName => "Tuvalu";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "توفالو"),
            new Translation(LanguageCode.AZ, "Tuvalu"),
            new Translation(LanguageCode.BE, "Тувалу"),
            new Translation(LanguageCode.BG, "Тувалу"),
            new Translation(LanguageCode.BS, "Tuvalu"),
            new Translation(LanguageCode.CA, "Tuvalu"),
            new Translation(LanguageCode.CS, "Tuvalu"),
            new Translation(LanguageCode.DA, "Tuvalu"),
            new Translation(LanguageCode.DE, "Tuvalu"),
            new Translation(LanguageCode.EL, "Τουβαλού"),
            new Translation(LanguageCode.EN, "Tuvalu"),
            new Translation(LanguageCode.ES, "Tuvalu"),
            new Translation(LanguageCode.ET, "Tuvalu"),
            new Translation(LanguageCode.FA, "تووالو"),
            new Translation(LanguageCode.FI, "Tuvalu"),
            new Translation(LanguageCode.FR, "Tuvalu"),
            new Translation(LanguageCode.HE, "טובאלו"),
            new Translation(LanguageCode.HR, "Tuvalu"),
            new Translation(LanguageCode.HU, "Tuvalu"),
            new Translation(LanguageCode.HY, "Տուվալու"),
            new Translation(LanguageCode.ID, "Tuvalu"),
            new Translation(LanguageCode.IT, "Tuvalu"),
            new Translation(LanguageCode.JA, "ツバル"),
            new Translation(LanguageCode.KA, "ტუვალუ"),
            new Translation(LanguageCode.KK, "Тувалу"),
            new Translation(LanguageCode.KO, "투발루"),
            new Translation(LanguageCode.KY, "Тувалу"),
            new Translation(LanguageCode.LT, "Tuvalu"),
            new Translation(LanguageCode.LV, "Tuvalu"),
            new Translation(LanguageCode.MK, "Тувалу"),
            new Translation(LanguageCode.MN, "Тувалу"),
            new Translation(LanguageCode.NB, "Tuvalu"),
            new Translation(LanguageCode.NL, "Tuvalu"),
            new Translation(LanguageCode.NN, "Tuvalu"),
            new Translation(LanguageCode.PL, "Tuvalu"),
            new Translation(LanguageCode.PT, "Tuvalu"),
            new Translation(LanguageCode.RO, "Tuvalu"),
            new Translation(LanguageCode.RU, "Тувалу"),
            new Translation(LanguageCode.SK, "Tuvalu"),
            new Translation(LanguageCode.SL, "Tuvalu"),
            new Translation(LanguageCode.SR, "Тувалу"),
            new Translation(LanguageCode.SV, "Tuvalu"),
            new Translation(LanguageCode.TR, "Tuvalu"),
            new Translation(LanguageCode.UK, "Тувалу"),
            new Translation(LanguageCode.UZ, "Tuvalu"),
            new Translation(LanguageCode.ZH, "图瓦卢"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.TV;
        public Alpha3Code Alpha3Code => Alpha3Code.TUV;
        public int NumericCode => 798;
        public string[] TLD => new [] { ".tv" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Polynesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new AudCurrency() };
        public string[] CallingCodes => new [] { "688" };
    }
}
