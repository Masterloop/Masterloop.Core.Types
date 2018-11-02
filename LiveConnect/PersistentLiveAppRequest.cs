namespace Masterloop.Core.Types.LiveConnect
{
    public class PersistentLiveAppRequest
    {
        /// <summary>
        /// Subscription key value.
        /// </summary>
        public string SubscriptionKey { get; set; }

        /// <summary>
        /// Live app request structures.
        /// </summary>
        public LiveAppRequest[] Requests { get; set; }
    }
}
