using TrainingRegistration.Debugging;

namespace TrainingRegistration
{
    public class TrainingRegistrationConsts
    {
        public const string LocalizationSourceName = "TrainingRegistration";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "39389b7723a24e1f8a9726e29d876af7";
    }
}
