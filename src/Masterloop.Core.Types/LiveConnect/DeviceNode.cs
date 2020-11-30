namespace Masterloop.Core.Types.LiveConnect
{
    public class DeviceNode
    {
        public string APIHost { get; set; }
        public int APIPortUEnc { get; set; }
        public int APIPortEnc { get; set; }
        public string MQHost { get; set; }
        public int MQPortUEnc { get; set; }
        public int MQPortEnc { get; set; }
    }

    public class DeviceNodeAMQP : DeviceNode
    {
        public string AMQPVHost { get; set; }
        public string AMQPQueue { get; set; }
        public string AMQPExchange { get; set; }
    }

    public class DeviceNodeMQTT : DeviceNode
    {
    }
}
