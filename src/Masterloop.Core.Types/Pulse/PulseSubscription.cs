using System;

namespace Masterloop.Core.Types.Pulse
{
    public class PulseSubscription
    {
        public readonly string MID;
        public readonly int PulseId;
        public readonly Action<string, int, Pulse> PulseHandler;

        public PulseSubscription(string mid, int pulseId, Action<string, int, Pulse> pulseHandler)
        {
            MID = mid;
            PulseId = pulseId;
            PulseHandler = pulseHandler;
        }
    }
}
