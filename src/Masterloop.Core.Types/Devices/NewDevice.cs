using System;

namespace Masterloop.Core.Types.Devices
{
    public class NewDevice
    {
        public string TemplateId { get; set; }

        public int? FirmwareVariantId { get; set; }

        public string MID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string PreSharedKey { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }
    }
}
