﻿using Masterloop.Core.Types.Base;
using System;

namespace Masterloop.Core.Types.Observations
{
    public class ObservationStringConverter
    {
        public static Observation StringToObservation(DateTime timestamp, string value, DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Binary: return new BinaryObservation() { Timestamp = timestamp, Value = DataTypeStringConverter.ParseBinaryValue(value) };
                case DataType.Boolean: return new BooleanObservation() { Timestamp = timestamp, Value = DataTypeStringConverter.ParseBooleanValue(value) };
                case DataType.Double: return new DoubleObservation() { Timestamp = timestamp, Value = DataTypeStringConverter.ParseDoubleValue(value) };
                case DataType.Integer: return new IntegerObservation() { Timestamp = timestamp, Value = DataTypeStringConverter.ParseIntegerValue(value) };
                case DataType.Position: return new PositionObservation() { Timestamp = timestamp, Value = DataTypeStringConverter.ParsePositionValue(value) };
                case DataType.String: return new StringObservation() { Timestamp = timestamp, Value = value };
                case DataType.Statistics: return new StatisticsObservation() { Timestamp = timestamp, Value = DataTypeStringConverter.ParseStatisticsValue(value) };
                default: return null;
            }
        }

        public static string ObservationToValueString(Observation o, DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Binary: return DataTypeStringConverter.FormatBinary(((BinaryObservation)o).Value);
                case DataType.Boolean: return DataTypeStringConverter.FormatBoolean(((BooleanObservation)o).Value);
                case DataType.Double: return DataTypeStringConverter.FormatDouble(((DoubleObservation)o).Value);
                case DataType.Integer: return DataTypeStringConverter.FormatInteger(((IntegerObservation)o).Value);
                case DataType.Position: return DataTypeStringConverter.FormatPosition(((PositionObservation)o).Value);
                case DataType.String: return ((StringObservation)o).Value;
                case DataType.Statistics: return DataTypeStringConverter.FormatStatistics(((StatisticsObservation)o).Value);
                default: return null;
            }
        }
    }
}