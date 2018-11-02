using Masterloop.Core.Types.Commands;
using Masterloop.Core.Types.Settings;
using Masterloop.Core.Types.Firmware;

namespace Masterloop.Core.Types.DevSync
{
    public class DevSyncResponse
    {
        /// <summary>
        /// New setting, or null if no new settings exist.
        /// </summary>
        public ExpandedSettingsPackage Settings { get; set; }

        /// <summary>
        /// List of new commands.
        /// </summary>
        public Command[] Commands { get; set; }

        /// <summary>
        /// New firmware patch metadata, or null if no new firmware exists or if delta is not used.
        /// </summary>
        public FirmwarePatchDescriptor FirmwarePatchMetadata { get; set; }

        /// <summary>
        /// New firmware release metadata, or null if no new firmware exists or if delta updating is used.
        /// </summary>
        public FirmwareReleaseDescriptor FirmwareReleaseMetadata { get; set; }

        /// <summary>
        /// New firmware bytes as Base64 string, or null if no new firmware exists.
        /// </summary>
        public string FirmwareBlob { get; set; }

        /// <summary>
        /// Time of server when request was returned to device.
        /// </summary>
        public string ServerTime { get; set; }
    }
}
