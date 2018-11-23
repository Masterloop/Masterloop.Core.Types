using Masterloop.Core.Types.Observations;
using Masterloop.Core.Types.Pulse;
using Masterloop.Core.Types.Settings;

namespace Masterloop.Core.Types.ImportExport
{
    public class SnapshotItem
    {
        public string MID { get; set; }
        public ExpandedObservationValue[] Observations { get; set; }
        public ExpandedSettingValue[] Settings { get; set; }
        public IdentifiedPulsePeriod[] PulsePeriods { get; set; }
    }
}
