using Masterloop.Core.Types.Base;
using System;

namespace Masterloop.Core.Types.Devices
{
    public class DeviceCommandArgument
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DataType DataType { get; set; }
    }
}
