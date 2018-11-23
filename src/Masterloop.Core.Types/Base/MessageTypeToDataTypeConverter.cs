using Masterloop.Core.Types.LiveConnect;
using System;

namespace Masterloop.Core.Types.Base
{
    public class MessageTypeToDataTypeConverter
    {
        public static DataType ToDataType(string mdt)
        {
            switch (mdt)
            {
                case MessageDataType.BooleanObservation: return DataType.Boolean;
                case MessageDataType.DoubleObservation: return DataType.Double;
                case MessageDataType.IntegerObservation: return DataType.Integer;
                case MessageDataType.PositionObservation: return DataType.Position;
                case MessageDataType.StringObservation: return DataType.String;
                default: throw new ArgumentException("Cannot convert MessageDataType of this type to DataType: " + mdt.ToString());
            }
        }

        public static string ToMDT(DataType dt)
        {
            switch (dt)
            {
                case DataType.Boolean: return MessageDataType.BooleanObservation;
                case DataType.Double: return MessageDataType.DoubleObservation;
                case DataType.Integer: return MessageDataType.IntegerObservation;
                case DataType.Position: return MessageDataType.PositionObservation;
                case DataType.String: return MessageDataType.StringObservation;
                default: throw new ArgumentException("Cannot convert MessageDataType of this DataType: " + dt.ToString());
            }
        }
    }
}
