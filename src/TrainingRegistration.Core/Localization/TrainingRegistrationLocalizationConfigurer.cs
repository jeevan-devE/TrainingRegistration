using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TrainingRegistration.Localization
{
    public static class TrainingRegistrationLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TrainingRegistrationConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TrainingRegistrationLocalizationConfigurer).GetAssembly(),
                        "TrainingRegistration.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
