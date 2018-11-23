namespace Masterloop.Core.Types.LiveConnect
{
    public class LiveAppRequest
    {
        /// <summary>
        /// Template identifier
        /// </summary>
        public string TID;

        /// <summary>
        /// Device identifier
        /// </summary>
        public string MID;

        /// <summary>
        /// Listen to all observations from device
        /// </summary>
        public bool ConnectAllObservations;

        /// <summary>
        /// Send all commands to device
        /// </summary>
        public bool ConnectAllCommands;

        /// <summary>
        /// Listen to specific observations from device
        /// </summary>
        public int[] ObservationIds;

        /// <summary>
        /// Send specific commands to device
        /// </summary>
        public int[] CommandIds;

        /// <summary>
        /// Initialize observations with current values
        /// </summary>
        public bool InitObservationValues;

        /// <summary>
        /// Receive device pulse signal (if sent by device)
        /// </summary>
        public bool ReceiveDevicePulse;

        /// <summary>
        /// Application pulse identifier used when sending pulse signal to device
        /// </summary>
        public int? PulseId;
    }
}
