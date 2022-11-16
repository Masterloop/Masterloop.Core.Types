using Masterloop.Core.Types.Base;

namespace Masterloop.Core.Types.Devices
{
    public class DeviceObservation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DataType DataType { get; set; }

        public HistorianType Historian { get; set; }

        public double HistorianStep { get; set; }

        public int Quantity { get; set; }

        public int Unit { get; set; }
    }
}