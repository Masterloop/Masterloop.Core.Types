using Masterloop.Core.Types.Commands;

namespace Masterloop.Core.Types.DevSync
{
    public class DevSyncRequest
    {
        /// <summary>
        /// Observations text formatted according to the Masterloop Compact Observation Format, or null if observations are not used.
        /// </summary>
        public string Observations { get; set; }

        /// <summary>
        /// Array of command responses or null if no command responses exist.
        /// </summary>
        public CommandResponse[] CommandResponses { get; set; }

        /// <summary>
        /// Timestamp of settings on device as received from previous device settings update (formatted as ISO 8601), or null if settings is not used.
        /// </summary>
        public string SettingsTimestamp { get; set; }

        /// <summary>
        /// True if delta patching is used, False if full firmware file shall always be downloaded.
        /// </summary>
        public bool FirmwareUseDeltaPatching { get; set; }

        /// <summary>
        /// Masterloop-assigned identifier of firmware release as received from previous firmware update, or -1 if firmware updating is not used.
        /// </summary>
        public int FirmwareReleaseId { get; set; }
    }
}
