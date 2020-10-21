using Masterloop.Core.Types.Base;

namespace Masterloop.Core.Types.Settings
{
    public class ExpandedSettingValue : SettingValue
    {
        public string Name { get; set; }

        public DataType DataType { get; set; }

        public bool IsDefaultValue { get; set; }

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

        public void SetBoolean(bool value)
        {
            Value = DataTypeStringConverter.FormatBoolean(value);
        }

        public void SetDouble(double value)
        {
            Value = DataTypeStringConverter.FormatDouble(value);
        }

        public void SetInteger(int value)
        {
            Value = DataTypeStringConverter.FormatInteger(value);
        }

        public void SetPosition(Position value)
        {
            Value = DataTypeStringConverter.FormatPosition(value);
        }

        public void SetString(string value)
        {
            Value = value;
        }
    }
}
