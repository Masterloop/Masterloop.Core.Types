namespace Masterloop.Core.Types.Firmware
{
    public class FirmwareRelease
    {
        /// <summary>
        /// Template identifier which the firmware belongs to.
        /// </summary>
        public string DeviceTemplateId { get; set; }

        /// <summary>
        /// Firmware variant identifier (optional).
        /// </summary>
        public int? VariantId { get; set; }

        /// <summary>
        /// User version string.
        /// </summary>
        public string VersionNo { get; set; }

        /// <summary>
        /// Size of blob.
        /// </summary>
        public int BlobSize { get; set; }

        /// <summary>
        /// Base64 encoced blob data.
        /// </summary>
        public string BlobData { get; set; }
    }
}
