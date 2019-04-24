namespace Masterloop.Core.Types.LiveConnect
{
    public class LiveAppRequest : LiveRequest
    {
        /// <summary>
        /// Template identifier, use either TID or MID (not both).
        /// </summary>
        public string TID;

        /// <summary>
        /// Device identifier, use either TID or MID (not both).
        /// </summary>
        public string MID;
    }
}
