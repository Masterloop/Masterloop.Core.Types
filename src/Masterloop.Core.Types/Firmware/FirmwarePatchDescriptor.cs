using System;
using System.Collections.Generic;
using System.Text;

namespace Masterloop.Core.Types.Firmware
{
    public class FirmwarePatchDescriptor
    {
        public int FromFirmwareReleaseId { get; set; }

        public int ToFirmwareReleaseId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int Size { get; set; }

        public string Url { get; set; }

        public string Encoding { get; set; }

        public string PatchMD5 { get; set; }

        public string FirmwareMD5 { get; set; }
    }
}
