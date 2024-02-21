using QB.SeatAllocation.Debugging;

namespace QB.SeatAllocation
{
    public class SeatAllocationConsts
    {
        public const string LocalizationSourceName = "SeatAllocation";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "c23e271030ae4740941f488c9b147e48";
    }
}
