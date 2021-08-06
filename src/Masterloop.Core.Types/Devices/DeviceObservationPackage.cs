using System;
namespace Masterloop.Core.Types.Devices
{
    public class DeviceObservationPackage
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DeviceObservationPackageItem[] Observations { get; set; }
    }
}
