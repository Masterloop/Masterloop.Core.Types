using Masterloop.Core.Types.Base;
using System;

namespace Masterloop.Core.Types.Observations
{
    public class ObservationStringConverter
    {
        public static Observation StringToObservation(DateTime timestamp, string value, DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Boolean: return new BooleanObservation() { Timestamp = timestamp, Value = DataTypeStringConverter.ParseBooleanValue(value) };
                case DataType.Double: return new DoubleObservation() { Timestamp = timestamp, Value = DataTypeStringConverter.ParseDoubleValue(value) };
                case DataType.Integer: return new IntegerObservation() { Timestamp = timestamp, Value = DataTypeStringConverter.ParseIntegerValue(value) };
                case DataType.Position: return new PositionObservation() { Timestamp = timestamp, Value = DataTypeStringConverter.ParsePositionValue(value) };
                case DataType.String: return new StringObservation() { Timestamp = timestamp, Value = value };
                default: return null;
            }
        }
    }
}
