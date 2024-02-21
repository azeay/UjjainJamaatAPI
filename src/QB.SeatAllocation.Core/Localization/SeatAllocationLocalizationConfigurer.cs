using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace QB.SeatAllocation.Localization
{
    public static class SeatAllocationLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SeatAllocationConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SeatAllocationLocalizationConfigurer).GetAssembly(),
                        "QB.SeatAllocation.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
