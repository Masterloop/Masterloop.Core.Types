using System;

namespace Masterloop.Core.Types.LiveConnect
{
    public class DeviceConnection
    {
        public DateTime ServerTime { get; set; }
        public DeviceNode Node { get; set; }
        public UInt16 BackoffSeconds { get; set; }
    }
}