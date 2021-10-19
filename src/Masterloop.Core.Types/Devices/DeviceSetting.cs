using Masterloop.Core.Types.Base;
using System;

namespace Masterloop.Core.Types.Devices
{
    public class DeviceSetting
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DataType DataType { get; set; }

        public int Quantity { get; set; }

        public int Unit { get; set; }

        public bool IsRequired { get; set; }

        public string DefaultValue { get; set; }

        public DateTime LastUpdatedOn { get; set; }
    }
}