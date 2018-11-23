using Masterloop.Core.Types.Base;

namespace Masterloop.Core.Types.Observations
{
    public class ExpandedObservationValue : ObservationValue
    {
        public DataType DataType { get; set; }

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
    }
}
