using Masterloop.Core.Types.Pulse;
using System;

namespace Masterloop.Core.Types.Devices
{
    public class DetailedDevice : Device
    {
        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public DateTime? LatestPulse { get; set; }
    }
}
