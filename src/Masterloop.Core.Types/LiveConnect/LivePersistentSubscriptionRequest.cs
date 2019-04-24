namespace Masterloop.Core.Types.LiveConnect
{
    public class LivePersistentSubscriptionRequest : LiveRequest
    {
        /// <summary>
        /// Template identifier.
        /// </summary>
        public string TID;

        /// <summary>
        /// Device identifiers, set to null to subscribe to all devices of template TID.
        /// </summary>
        public string[] MIDs;

        /// <summary>
        /// Subscription key value.
        /// </summary>
        public string SubscriptionKey { get; set; }
    }
}