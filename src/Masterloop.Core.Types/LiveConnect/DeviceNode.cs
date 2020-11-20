namespace Masterloop.Core.Types.LiveConnect
{
    public class DeviceNode
    {
        public int PortUnencrypted { get; set; }
        public int PortEncrypted { get; set; }
        public string HostName { get; set; }
    }

    public class DeviceNodeAMQP : DeviceNode
    {
        public string VHost { get; set; }
        public string Queue { get; set; }
        public string Exchange { get; set; }
    }

    public class DeviceNodeMQTT : DeviceNode
    {
    }
}
