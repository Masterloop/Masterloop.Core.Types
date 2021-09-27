namespace Masterloop.Core.Types.Devices
{
    public class DeviceTemplate
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Revision { get; set; }

        public DeviceProtocolType Protocol { get; set; }

        public DeviceObservation[] Observations { get; set; }

        public DeviceObservationPackage[] ObservationPackages { get; set; }

        public DeviceCommand[] Commands { get; set; }

        public DeviceSetting[] Settings { get; set; }

        public DevicePulse[] Pulses { get; set; }
    }
}