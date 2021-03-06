using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guadeloupe
    /// </summary>
    public class GuadeloupeInfo : ICountryInfo
    {
        public string CommonName => "Guadeloupe";
        public string OfficialName => "Guadeloupe";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "غوادلوب"),
            new Translation(LanguageCode.AZ, "Qvadelupa"),
            new Translation(LanguageCode.BE, "Гвадэлупа"),
            new Translation(LanguageCode.BG, "Гваделупа"),
            new Translation(LanguageCode.BS, "Gvadalupe"),
            new Translation(LanguageCode.CA, "Guadeloupe"),
            new Translation(LanguageCode.CS, "Guadeloupe"),
            new Translation(LanguageCode.DA, "Guadeloupe"),
            new Translation(LanguageCode.DE, "Guadeloupe"),
            new Translation(LanguageCode.EL, "Γουαδελούπη"),
            new Translation(LanguageCode.EN, "Guadeloupe"),
            new Translation(LanguageCode.ES, "Guadeloupe"),
            new Translation(LanguageCode.ET, "Guadeloupe"),
            new Translation(LanguageCode.FA, "گوادلوپ"),
            new Translation(LanguageCode.FI, "Guadeloupe"),
            new Translation(LanguageCode.FR, "Guadeloupe"),
            new Translation(LanguageCode.HE, "גוואדלופ"),
            new Translation(LanguageCode.HR, "Guadalupe"),
            new Translation(LanguageCode.HU, "Guadeloupe"),
            new Translation(LanguageCode.HY, "Գվադելուպա"),
            new Translation(LanguageCode.ID, "Guadeloupe"),
            new Translation(LanguageCode.IT, "Guadalupa"),
            new Translation(LanguageCode.JA, "グアドループ"),
            new Translation(LanguageCode.KA, "გვადელუპა"),
            new Translation(LanguageCode.KK, "Гваделупа"),
            new Translation(LanguageCode.KO, "과들루프"),
            new Translation(LanguageCode.KY, "Гваделупа"),
            new Translation(LanguageCode.LT, "Gvadelupa"),
            new Translation(LanguageCode.LV, "Gvadelupa"),
            new Translation(LanguageCode.MK, "Гвадалупе"),
            new Translation(LanguageCode.MN, "Гваделуп"),
            new Translation(LanguageCode.NB, "Guadeloupe"),
            new Translation(LanguageCode.NL, "Guadeloupe"),
            new Translation(LanguageCode.NN, "Guadeloupe"),
            new Translation(LanguageCode.PL, "Gwadelupa"),
            new Translation(LanguageCode.PT, "Guadalupe"),
            new Translation(LanguageCode.RO, "Guadelupa"),
            new Translation(LanguageCode.RU, "Гваделупа"),
            new Translation(LanguageCode.SK, "Guadeloupe"),
            new Translation(LanguageCode.SL, "Gvadalupe"),
            new Translation(LanguageCode.SR, "Гваделуп"),
            new Translation(LanguageCode.SV, "Guadeloupe"),
            new Translation(LanguageCode.TR, "Guadalupe"),
            new Translation(LanguageCode.UK, "Гваделупа"),
            new Translation(LanguageCode.UZ, "Gvadelupe"),
            new Translation(LanguageCode.ZH, "瓜德罗普"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.GP;
        public Alpha3Code Alpha3Code => Alpha3Code.GLP;
        public int NumericCode => 312;
        public string[] TLD => new [] { ".gp" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "590" };
    }
}
