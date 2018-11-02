using System;

namespace Masterloop.Core.Types.Devices
{
    public class Device
    {
        public string TemplateId { get; set; }

        public string MID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DeviceTemplate Metadata { get; set; }
    }
}
