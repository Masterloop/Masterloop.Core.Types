using Masterloop.Core.Types.Base;
using Masterloop.Core.Types.Observations;

namespace Masterloop.Core.Types.Devices
{
    public class DeviceObservation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DataType DataType { get; set; }

        public int ExpectedLoggingInterval { get; set; }
    }
}
