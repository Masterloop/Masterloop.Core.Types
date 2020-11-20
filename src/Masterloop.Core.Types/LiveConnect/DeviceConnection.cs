using Masterloop.Core.Types.Devices;
using Masterloop.Core.Types.Settings;
using System;

namespace Masterloop.Core.Types.LiveConnect
{
    public class DeviceConnection
    {
        public DateTime ServerTime { get; set; }
        public DeviceNode Node { get; set; }
        public SettingsPackage Settings { get; set; }
    }
}