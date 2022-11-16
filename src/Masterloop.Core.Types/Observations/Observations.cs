using Masterloop.Core.Types.Base;
using System;

namespace Masterloop.Core.Types.Observations
{
    public class Observation
    {
        public DateTime Timestamp { get; set; }
    }

    public class BinaryObservation : Observation
    {
        public byte[] Value { get; set; }
    }

    public class BooleanObservation : Observation
    {
        public bool Value { get; set; }
    }

    public class DoubleObservation : Observation
    {
        public double Value { get; set; }
    }

    public class IntegerObservation : Observation
    {
        public Int32 Value { get; set; }
    }

    public class PositionObservation : Observation
    {
        public Position Value { get; set; }
    }

    public class StringObservation : Observation
    {
        public string Value { get; set; }
    }

    public class StatisticsObservation : Observation
    {
        public DescriptiveStatistics Value { get; set; }
    }
}
