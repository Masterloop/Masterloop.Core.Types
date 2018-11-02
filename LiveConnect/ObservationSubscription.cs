using Masterloop.Core.Types.Observations;
using System;

namespace Masterloop.Core.Types.LiveConnect
{
    public class ObservationSubscription<T>
    {
        public readonly string MID;
        public readonly int ObservationId;
        public readonly Action<string, int, T> ObservationHandler;

        public ObservationSubscription(string mid, int observationId, Action<string, int, T> observationHandler)
        {
            MID = mid;
            ObservationId = observationId;
            ObservationHandler = observationHandler;
        }
    }
}
