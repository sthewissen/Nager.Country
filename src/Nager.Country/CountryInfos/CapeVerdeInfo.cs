using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cape Verde
    /// </summary>
    public class CapeVerdeInfo : ICountryInfo
    {
        public string CommonName => "Cape Verde";
        public string OfficialName => "Republic of Cabo Verde";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الرأس الأخضر"),
            new Translation(LanguageCode.AZ, "Kabo-Verde"),
            new Translation(LanguageCode.BE, "Каба-Вердэ"),
            new Translation(LanguageCode.BG, "Кабо Верде"),
            new Translation(LanguageCode.BS, "Kape Verde"),
            new Translation(LanguageCode.CA, "Cap Verd"),
            new Translation(LanguageCode.CS, "Kapverdy"),
            new Translation(LanguageCode.DA, "Kap Verde"),
            new Translation(LanguageCode.DE, "Kap Verde"),
            new Translation(LanguageCode.EL, "Δημοκρατία του Πράσινου Ακρωτηρίου"),
            new Translation(LanguageCode.EN, "Cape Verde"),
            new Translation(LanguageCode.ES, "Cabo Verde"),
            new Translation(LanguageCode.ET, "Roheneemesaared"),
            new Translation(LanguageCode.FA, "کیپ‌ورد"),
            new Translation(LanguageCode.FI, "Kap Verde"),
            new Translation(LanguageCode.FR, "Cap-Vert"),
            new Translation(LanguageCode.HE, "כף ורדה"),
            new Translation(LanguageCode.HR, "Zelenortska Republika"),
            new Translation(LanguageCode.HU, "Zöld-foki Köztársaság"),
            new Translation(LanguageCode.HY, "Կաբո Վերդե"),
            new Translation(LanguageCode.ID, "Tanjung Verde"),
            new Translation(LanguageCode.IT, "Capo Verde"),
            new Translation(LanguageCode.JA, "カーボベルデ"),
            new Translation(LanguageCode.KA, "კაბო-ვერდე"),
            new Translation(LanguageCode.KK, "Кабо-Верде"),
            new Translation(LanguageCode.KO, "카보 베르데"),
            new Translation(LanguageCode.KY, "Капе Верде"),
            new Translation(LanguageCode.LT, "Žaliasis Kyšulys"),
            new Translation(LanguageCode.LV, "Kaboverde"),
            new Translation(LanguageCode.MK, "Зелен ’Рт"),
            new Translation(LanguageCode.MN, "Капе Верде"),
            new Translation(LanguageCode.NB, "Kapp Verde"),
            new Translation(LanguageCode.NL, "Kaapverdië"),
            new Translation(LanguageCode.NN, "Kapp Verde"),
            new Translation(LanguageCode.PL, "Republika Zielonego Przylądka"),
            new Translation(LanguageCode.PT, "Cabo Verde"),
            new Translation(LanguageCode.RO, "Capul Verde"),
            new Translation(LanguageCode.RU, "Кабо-Верде"),
            new Translation(LanguageCode.SK, "Kapverdy"),
            new Translation(LanguageCode.SL, "Zelenortski otoki"),
            new Translation(LanguageCode.SR, "Зеленортска Острва"),
            new Translation(LanguageCode.SV, "Kap Verde"),
            new Translation(LanguageCode.TR, "Cape Verde"),
            new Translation(LanguageCode.UK, "Кабо-Верде"),
            new Translation(LanguageCode.UZ, "Kabo-Verde"),
            new Translation(LanguageCode.ZH, "佛得角"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.CV;
        public Alpha3Code Alpha3Code => Alpha3Code.CPV;
        public int NumericCode => 132;
        public string[] TLD => new [] { ".cv" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new CveCurrency() };
        public string[] CallingCodes => new [] { "238" };
    }
}
