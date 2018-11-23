using System;

namespace Masterloop.Core.Types.Observations
{
    public class ObservationValue
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Value { get; set; }
    }
}
