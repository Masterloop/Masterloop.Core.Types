using Masterloop.Core.Types.Base;

namespace Masterloop.Core.Types.Observations
{
    public class ExpandedObservationValue : ObservationValue
    {
        public DataType DataType { get; set; }

        public ExpandedObservationValue()
        {
        }

        public ExpandedObservationValue(int id, DataType dataType, Observation observation)
        {
            this.Id = id;
            this.DataType = dataType;
            this.Timestamp = observation.Timestamp;
            this.Value = ObservationStringConverter.ObservationToValueString(observation, dataType);
        }

        public bool ToBoolean()
        {
            return DataTypeStringConverter.ParseBooleanValue(Value);
        }

        public double ToDouble()
        {
            return DataTypeStringConverter.ParseDoubleValue(Value);
        }

        public int ToInteger()
        {
            return DataTypeStringConverter.ParseIntegerValue(Value);
        }

        public Position ToPosition()
        {
            return DataTypeStringConverter.ParsePositionValue(Value);
        }

        public new string ToString()
        {
            return Value;
        }

        public DescriptiveStatistics ToStatistics()
        {
            return DataTypeStringConverter.ParseStatisticsValue(Value);
        }

        public Observation ToObservation()
        {
            switch (DataType)
            {
                case DataType.Boolean: return new BooleanObservation() { Timestamp = this.Timestamp, Value = ToBoolean() };
                case DataType.Double: return new DoubleObservation() { Timestamp = this.Timestamp, Value = ToDouble() };
                case DataType.Integer: return new IntegerObservation() { Timestamp = this.Timestamp, Value = ToInteger() };
                case DataType.Position: return new PositionObservation() { Timestamp = this.Timestamp, Value = ToPosition() };
                case DataType.String: return new StringObservation() { Timestamp = this.Timestamp, Value = ToString() };
                case DataType.Statistics: return new StatisticsObservation() { Timestamp = this.Timestamp, Value = ToStatistics() };
                default: return null;
            }
        }
    }
}