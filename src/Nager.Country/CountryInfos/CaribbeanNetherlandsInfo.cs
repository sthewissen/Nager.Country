﻿using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Caribbean Netherlands
    /// </summary>
    public class CaribbeanNetherlandsInfo : ICountryInfo
    {
        public string CommonName => "Caribbean Netherlands";
        public string OfficialName => "Caribbean Netherlands";
        public Translation[] Translations => new[]
        {
            new Translation(LanguageCode.EN, "Caribbean Netherlands"),
            new Translation(LanguageCode.DE, "Caribbean Netherlands"),
            new Translation(LanguageCode.NL, "Caribbean Netherlands"),
            new Translation(LanguageCode.FR, "Caribbean Netherlands"),
            new Translation(LanguageCode.ES, "Caribbean Netherlands"),
            new Translation(LanguageCode.IT, "Caribbean Netherlands"),
        };

        public Alpha2Code Alpha2Code => Alpha2Code.BQ;
        public Alpha3Code Alpha3Code => Alpha3Code.BES;
        public int NumericCode => 535;
        public string[] TLD => new[] { ".bq", ".nl" };

        public Region Region => Region.Americas;
        public SubRegion SubRegion => SubRegion.Caribbean;

        public Alpha2Code[] BorderCountries => new Alpha2Code[0];

        public ICurrency[] Currencies => new[] { new UsdCurrency() };
        public string[] CallingCodes => new[] { "599" };
    }
}
