using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Italy
    /// </summary>
    public class ItalyInfo : ICountryInfo
    {
        public string CommonName => "Italy";
        public string OfficialName => "Italian Republic";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "إيطاليا"),
            new Translation(LanguageCode.AZ, "İtaliya"),
            new Translation(LanguageCode.BE, "Італія"),
            new Translation(LanguageCode.BG, "Италия"),
            new Translation(LanguageCode.BS, "Italija"),
            new Translation(LanguageCode.CA, "Itàlia"),
            new Translation(LanguageCode.CS, "Itálie"),
            new Translation(LanguageCode.DA, "Italien"),
            new Translation(LanguageCode.DE, "Italien"),
            new Translation(LanguageCode.EL, "Ιταλία"),
            new Translation(LanguageCode.EN, "Italy"),
            new Translation(LanguageCode.ES, "Italia"),
            new Translation(LanguageCode.ET, "Itaalia"),
            new Translation(LanguageCode.FA, "ایتالیا"),
            new Translation(LanguageCode.FI, "Italia"),
            new Translation(LanguageCode.FR, "Italie"),
            new Translation(LanguageCode.HE, "איטליה"),
            new Translation(LanguageCode.HR, "Italija"),
            new Translation(LanguageCode.HU, "Olaszország"),
            new Translation(LanguageCode.HY, "Իտալիա"),
            new Translation(LanguageCode.ID, "Italia"),
            new Translation(LanguageCode.IT, "Italia"),
            new Translation(LanguageCode.JA, "イタリア"),
            new Translation(LanguageCode.KA, "იტალია"),
            new Translation(LanguageCode.KK, "Италия"),
            new Translation(LanguageCode.KO, "이탈리아"),
            new Translation(LanguageCode.KY, "Италия"),
            new Translation(LanguageCode.LT, "Italija"),
            new Translation(LanguageCode.LV, "Itālija"),
            new Translation(LanguageCode.MK, "Италија"),
            new Translation(LanguageCode.MN, "Итали"),
            new Translation(LanguageCode.NB, "Italia"),
            new Translation(LanguageCode.NL, "Italië"),
            new Translation(LanguageCode.NN, "Italia"),
            new Translation(LanguageCode.PL, "Włochy"),
            new Translation(LanguageCode.PT, "Itália"),
            new Translation(LanguageCode.RO, "Italia"),
            new Translation(LanguageCode.RU, "Италия"),
            new Translation(LanguageCode.SK, "Taliansko"),
            new Translation(LanguageCode.SL, "Italija"),
            new Translation(LanguageCode.SR, "Италија"),
            new Translation(LanguageCode.SV, "Italien"),
            new Translation(LanguageCode.TR, "İtalya"),
            new Translation(LanguageCode.UK, "Італія"),
            new Translation(LanguageCode.UZ, "Italiya"),
            new Translation(LanguageCode.ZH, "意大利"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.IT;
        public Alpha3Code Alpha3Code => Alpha3Code.ITA;
        public int NumericCode => 380;
        public string[] TLD => new [] { ".it" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AT,
            Alpha2Code.FR,
            Alpha2Code.SM,
            Alpha2Code.SI,
            Alpha2Code.CH,
            Alpha2Code.VA,
        };

        public ICurrency[] Currencies => new [] { new EurCurrency() };
        public string[] CallingCodes => new [] { "39" };
    }
}
