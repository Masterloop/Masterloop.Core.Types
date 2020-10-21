namespace Masterloop.Core.Types.LiveConnect
{
    public class DeviceNode
    {
        public int Port { get; set; }
        public string Server { get; set; }
        public bool UseEncryption { get; set; }
        public string Username { get; set; }
    }

    public class DeviceNodeAMQP : DeviceNode
    {
        public string VHost { get; set; }
        public string Queue { get; set; }
        public string Exchange { get; set; }
    }

    public class DeviceNodeMQTT : DeviceNode
    {
        public string PubRoot { get; set; }
        public string SubRoot { get; set; }
        public string MasterPulse { get; set; }
    }
}
