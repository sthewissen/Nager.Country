using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Senegal
    /// </summary>
    public class SenegalInfo : ICountryInfo
    {
        public string CommonName => "Senegal";
        public string OfficialName => "Republic of Senegal";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "السنغال"),
            new Translation(LanguageCode.AZ, "Seneqal"),
            new Translation(LanguageCode.BE, "Сенегал"),
            new Translation(LanguageCode.BG, "Сенегал"),
            new Translation(LanguageCode.BS, "Senegal"),
            new Translation(LanguageCode.CA, "Senegal"),
            new Translation(LanguageCode.CS, "Senegal"),
            new Translation(LanguageCode.DA, "Senegal"),
            new Translation(LanguageCode.DE, "Senegal"),
            new Translation(LanguageCode.EL, "Σενεγάλη"),
            new Translation(LanguageCode.EN, "Senegal"),
            new Translation(LanguageCode.ES, "Senegal"),
            new Translation(LanguageCode.ET, "Senegal"),
            new Translation(LanguageCode.FA, "سنگال"),
            new Translation(LanguageCode.FI, "Senegal"),
            new Translation(LanguageCode.FR, "Sénégal"),
            new Translation(LanguageCode.HE, "סנגל"),
            new Translation(LanguageCode.HR, "Senegal"),
            new Translation(LanguageCode.HU, "Szenegál"),
            new Translation(LanguageCode.HY, "Սենեգալ"),
            new Translation(LanguageCode.ID, "Senegal"),
            new Translation(LanguageCode.IT, "Senegal"),
            new Translation(LanguageCode.JA, "セネガル"),
            new Translation(LanguageCode.KA, "სენეგალი"),
            new Translation(LanguageCode.KK, "Сенегал"),
            new Translation(LanguageCode.KO, "세네갈"),
            new Translation(LanguageCode.KY, "Сенегал"),
            new Translation(LanguageCode.LT, "Senegalas"),
            new Translation(LanguageCode.LV, "Senegāla"),
            new Translation(LanguageCode.MK, "Сенегал"),
            new Translation(LanguageCode.MN, "Сенегал"),
            new Translation(LanguageCode.NB, "Senegal"),
            new Translation(LanguageCode.NL, "Senegal"),
            new Translation(LanguageCode.NN, "Senegal"),
            new Translation(LanguageCode.PL, "Senegal"),
            new Translation(LanguageCode.PT, "Senegal"),
            new Translation(LanguageCode.RO, "Senegal"),
            new Translation(LanguageCode.RU, "Сенегал"),
            new Translation(LanguageCode.SK, "Senegal"),
            new Translation(LanguageCode.SL, "Senegal"),
            new Translation(LanguageCode.SR, "Сенегал"),
            new Translation(LanguageCode.SV, "Senegal"),
            new Translation(LanguageCode.TR, "Senegal"),
            new Translation(LanguageCode.UK, "Сенегал"),
            new Translation(LanguageCode.UZ, "Senegal"),
            new Translation(LanguageCode.ZH, "塞内加尔"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SN;
        public Alpha3Code Alpha3Code => Alpha3Code.SEN;
        public int NumericCode => 686;
        public string[] TLD => new [] { ".sn" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.GM,
            Alpha2Code.GN,
            Alpha2Code.GW,
            Alpha2Code.ML,
            Alpha2Code.MR,
        };

        public ICurrency[] Currencies => new [] { new XofCurrency() };
        public string[] CallingCodes => new [] { "221" };
    }
}
