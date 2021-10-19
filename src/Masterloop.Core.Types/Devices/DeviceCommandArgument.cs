using Masterloop.Core.Types.Base;

namespace Masterloop.Core.Types.Devices
{
    public class DeviceCommandArgument
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DataType DataType { get; set; }

        public int Quantity { get; set; }

        public int Unit { get; set; }
    }
}