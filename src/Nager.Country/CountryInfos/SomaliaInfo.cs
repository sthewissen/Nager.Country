using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Somalia
    /// </summary>
    public class SomaliaInfo : ICountryInfo
    {
        public string CommonName => "Somalia";
        public string OfficialName => "Federal Republic of Somalia";
        public Translation[] Translations => new []
        {
            new Translation(LanguageCode.AR, "الصومال"),
            new Translation(LanguageCode.AZ, "Somali"),
            new Translation(LanguageCode.BE, "Самалі"),
            new Translation(LanguageCode.BG, "Сомалия"),
            new Translation(LanguageCode.BS, "Somalija"),
            new Translation(LanguageCode.CA, "Somàlia"),
            new Translation(LanguageCode.CS, "Somálsko"),
            new Translation(LanguageCode.DA, "Somalia"),
            new Translation(LanguageCode.DE, "Somalia"),
            new Translation(LanguageCode.EL, "Σομαλία"),
            new Translation(LanguageCode.EN, "Somalia"),
            new Translation(LanguageCode.ES, "Somalia"),
            new Translation(LanguageCode.ET, "Somaalia"),
            new Translation(LanguageCode.FA, "سومالی"),
            new Translation(LanguageCode.FI, "Somalia"),
            new Translation(LanguageCode.FR, "Somalie"),
            new Translation(LanguageCode.HE, "סומליה"),
            new Translation(LanguageCode.HR, "Somalija"),
            new Translation(LanguageCode.HU, "Szomália"),
            new Translation(LanguageCode.HY, "Սոմալի"),
            new Translation(LanguageCode.ID, "Somalia"),
            new Translation(LanguageCode.IT, "Somalia"),
            new Translation(LanguageCode.JA, "ソマリア"),
            new Translation(LanguageCode.KA, "სომალი"),
            new Translation(LanguageCode.KK, "Сомали"),
            new Translation(LanguageCode.KO, "소말리아"),
            new Translation(LanguageCode.KY, "Сомали"),
            new Translation(LanguageCode.LT, "Somalis"),
            new Translation(LanguageCode.LV, "Somālija"),
            new Translation(LanguageCode.MK, "Сомалија"),
            new Translation(LanguageCode.MN, "Сомали"),
            new Translation(LanguageCode.NB, "Somalia"),
            new Translation(LanguageCode.NL, "Somalië"),
            new Translation(LanguageCode.NN, "Somalia"),
            new Translation(LanguageCode.PL, "Somalia"),
            new Translation(LanguageCode.PT, "Somália"),
            new Translation(LanguageCode.RO, "Somalia"),
            new Translation(LanguageCode.RU, "Сомали"),
            new Translation(LanguageCode.SK, "Somálsko"),
            new Translation(LanguageCode.SL, "Somalija"),
            new Translation(LanguageCode.SR, "Сомалија"),
            new Translation(LanguageCode.SV, "Somalia"),
            new Translation(LanguageCode.TR, "Somali"),
            new Translation(LanguageCode.UK, "Сомалі"),
            new Translation(LanguageCode.UZ, "Somali"),
            new Translation(LanguageCode.ZH, "索马利亚"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.SO;
        public Alpha3Code Alpha3Code => Alpha3Code.SOM;
        public int NumericCode => 706;
        public string[] TLD => new [] { ".so" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.DJ,
            Alpha2Code.ET,
            Alpha2Code.KE,
        };

        public ICurrency[] Currencies => new [] { new SosCurrency() };
        public string[] CallingCodes => new [] { "252" };
    }
}
