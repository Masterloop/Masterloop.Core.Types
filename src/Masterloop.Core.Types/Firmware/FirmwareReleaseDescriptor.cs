using System;
using System.Collections.Generic;
using System.Text;

namespace Masterloop.Core.Types.Firmware
{
    public class FirmwareReleaseDescriptor
    {
        public int Id { get; set; }

        public string VersionNo { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int Size { get; set; }

        public string FirmwareMD5 { get; set; }

        public string Url { get; set; }
    }
}
