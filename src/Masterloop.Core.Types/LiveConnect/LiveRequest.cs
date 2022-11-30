namespace Masterloop.Core.Types.LiveConnect
{
    public abstract class LiveRequest
    {
        /// <summary>
        /// Listen to all observations from device.
        /// </summary>
        public bool ConnectAllObservations { get; set; }

        /// <summary>
        /// Send all commands to device.
        /// </summary>
        public bool ConnectAllCommands { get; set; }

        /// <summary>
        /// Listen to specific observations from device.
        /// </summary>
        public int[] ObservationIds { get; set; }

        /// <summary>
        /// Send specific commands to device.
        /// </summary>
        public int[] CommandIds { get; set; }

        /// <summary>
        /// Initialize observations with current values.
        /// </summary>
        public bool InitObservationValues { get; set; }

        /// <summary>
        /// Receive device pulse signal (if sent by device).
        /// </summary>
        public bool ReceiveDevicePulse { get; set; }

        /// <summary>
        /// Application pulse identifier used when sending pulse signal to device.
        /// </summary>
        public int? PulseId { get; set; }
    }
}
