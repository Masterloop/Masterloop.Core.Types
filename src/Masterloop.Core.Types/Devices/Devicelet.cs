using System;

namespace Masterloop.Core.Types.Devices
{
    public class Devicelet
    {
        public string TID { get; set; }
        public string MID { get; set; }
        public string Name { get; set; }
        public DateTime? LatestPulse { get; set; }
    }
}