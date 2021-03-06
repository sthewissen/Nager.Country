using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Togo
    /// </summary>
    public class TogoInfo : ICountryInfo
    {
        public string CommonName => "Togo";
        public string OfficialName => "Togolese Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "توغو"),
            new Translation(LanguageCode.AZ, "Toqo"),
            new Translation(LanguageCode.BE, "Тога"),
            new Translation(LanguageCode.BG, "Того"),
            new Translation(LanguageCode.BS, "Togo"),
            new Translation(LanguageCode.CA, "Togo"),
            new Translation(LanguageCode.CS, "Togo"),
            new Translation(LanguageCode.DA, "Togo"),
            new Translation(LanguageCode.DE, "Togo"),
            new Translation(LanguageCode.EL, "Τογκό"),
            new Translation(LanguageCode.EN, "Togo"),
            new Translation(LanguageCode.ES, "Togo"),
            new Translation(LanguageCode.ET, "Togo"),
            new Translation(LanguageCode.FA, "توگو"),
            new Translation(LanguageCode.FI, "Togo"),
            new Translation(LanguageCode.FR, "Togo"),
            new Translation(LanguageCode.HE, "טוגו"),
            new Translation(LanguageCode.HR, "Togo"),
            new Translation(LanguageCode.HU, "Togo"),
            new Translation(LanguageCode.HY, "Տոգո"),
            new Translation(LanguageCode.ID, "Togo"),
            new Translation(LanguageCode.IT, "Togo"),
            new Translation(LanguageCode.JA, "トーゴ"),
            new Translation(LanguageCode.KA, "ტოგო"),
            new Translation(LanguageCode.KK, "Того"),
            new Translation(LanguageCode.KO, "가다"),
            new Translation(LanguageCode.KY, "Того"),
            new Translation(LanguageCode.LT, "Togas"),
            new Translation(LanguageCode.LV, "Togo"),
            new Translation(LanguageCode.MK, "Того"),
            new Translation(LanguageCode.MN, "Того"),
            new Translation(LanguageCode.NB, "Togo"),
            new Translation(LanguageCode.NL, "Togo"),
            new Translation(LanguageCode.NN, "Togo"),
            new Translation(LanguageCode.PL, "Togo"),
            new Translation(LanguageCode.PT, "Togo"),
            new Translation(LanguageCode.RO, "Togo"),
            new Translation(LanguageCode.RU, "Того"),
            new Translation(LanguageCode.SK, "Togo"),
            new Translation(LanguageCode.SL, "Togo"),
            new Translation(LanguageCode.SR, "Того"),
            new Translation(LanguageCode.SV, "Togo"),
            new Translation(LanguageCode.TR, "Togo"),
            new Translation(LanguageCode.UK, "Того"),
            new Translation(LanguageCode.UZ, "Togo"),
            new Translation(LanguageCode.ZH, "多哥"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.TG;
        public Alpha3Code Alpha3Code => Alpha3Code.TGO;
        public int NumericCode => 768;
        public string[] TLD => new [] { ".tg" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BJ,
            Alpha2Code.BF,
            Alpha2Code.GH,
        };

        public ICurrency[] Currencies => new [] { new XofCurrency() };
        public string[] CallingCodes => new [] { "228" };
    }
}
