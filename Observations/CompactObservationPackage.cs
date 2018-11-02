using Masterloop.Core.Types.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Masterloop.Core.Types.Observations
{
    public class CompactObservationPackage
    {
        public ObservationPackage Package { get; set; }

        public CompactObservationPackage(ObservationPackage package)
        {
            Package = package;
        }

        public CompactObservationPackage(string observations, Dictionary<int, DataType> observationDatatype)
        {
            Package = new ObservationPackage();

            // Example: 1,2015-05-04T15:08:45Z,3.14

            string pattern = "(?<observationId>\\d+),(?<timestamp>.*?),(?<value>.*)";
            string[] lines = observations.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                if (line != null && line.Length > 0)
                {
                    Regex regex = new Regex(pattern);
                    Match match = regex.Match(line);

                    int id;
                    if (Int32.TryParse(match.Groups["observationId"].Value, out id))
                    {
                        if (observationDatatype.ContainsKey(id))
                        {
                            DateTime timestamp = DateTime.UtcNow;
                            string ts = match.Groups["timestamp"].Value;
                            UInt32 secondsSince1970 = 0;
                            if (ts != "0")
                            {
                                if (DateTime.TryParse(ts, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out timestamp))
                                {
                                }
                                else if (UInt32.TryParse(ts, out secondsSince1970))
                                {
                                    timestamp = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(secondsSince1970);
                                }
                                else
                                {
                                    throw new ArgumentException("Invalid timestamp in line\n" + line);
                                }
                            }
                            string value = match.Groups["value"].Value;
                            if (value != null)
                            {
                                switch (observationDatatype[id])
                                {
                                    case DataType.Boolean:
                                        bool booleanValue = DataTypeStringConverter.ParseBooleanValue(value);
                                        AppendObservation(id, new BooleanObservation() { Timestamp = timestamp, Value = booleanValue });
                                        break;
                                    case DataType.Double:
                                        double doubleValue = DataTypeStringConverter.ParseDoubleValue(value);
                                        AppendObservation(id, new DoubleObservation() { Timestamp = timestamp, Value = doubleValue });
                                        break;
                                    case DataType.Integer:
                                        int integerValue = DataTypeStringConverter.ParseIntegerValue(value);
                                        AppendObservation(id, new IntegerObservation() { Timestamp = timestamp, Value = integerValue });
                                        break;
                                    case DataType.Position:
                                        Position positionValue = DataTypeStringConverter.ParsePositionValue(value);
                                        AppendObservation(id, new PositionObservation() { Timestamp = timestamp, Value = positionValue });
                                        break;
                                    case DataType.String:
                                        if (value.Length < 4096)
                                        {
                                            AppendObservation(id, new StringObservation() { Timestamp = timestamp, Value = value });
                                            break;
                                        }
                                        else
                                        {
                                            throw new ArgumentException("String values longer than 4096 characters are not supported. Tip: Use binary observation instead.");
                                        }
                                    default:
                                        throw new ArgumentException("Unsupported datatype in line\n" + line);
                                }
                            }
                            else
                            {
                                throw new ArgumentNullException("Value is null in line\n" + line);
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Unknown observation identifier in line\n" + line);
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Invalid ObservationId in line\n" + line);
                    }
                }
            }
        }

        #region Appenders
        public void AppendObservation(int observationId, Observation observation)
        {
            IdentifiedObservations IO = null;
            if (Package.Observations != null && Package.Observations.Length > 0)
            {
                foreach (IdentifiedObservations io in Package.Observations)
                {
                    if (io.ObservationId == observationId)
                    {
                        IO = io;
                        break;
                    }
                }
            }
            if (IO == null)  // Insert new identified observation into array
            {
                IO = new IdentifiedObservations()
                {
                    ObservationId = observationId, 
                    Observations = null 
                };
                List<IdentifiedObservations> ios = new List<IdentifiedObservations>();
                if (Package.Observations != null && Package.Observations.Length > 0)
                {
                    ios.AddRange(Package.Observations);
                }
                ios.Add(IO);
                Package.Observations = ios.ToArray();
            }
            List<Observation> o = new List<Observation>();
            if (IO.Observations != null && IO.Observations.Length > 0)
            {
                o.AddRange(IO.Observations);
            }
            o.Add(observation);  // Insert observation into array
            IO.Observations = o.ToArray();
        }
        #endregion

        #region Query
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IdentifiedObservations io in Package.Observations)
            {
                foreach (Observation o in io.Observations)
                {
                    string value;
                    if (o is BooleanObservation) value = DataTypeStringConverter.FormatBoolean(((BooleanObservation)(o)).Value);
                    else if (o is DoubleObservation) value = DataTypeStringConverter.FormatDouble(((DoubleObservation)(o)).Value);
                    else if (o is IntegerObservation) value = DataTypeStringConverter.FormatInteger(((IntegerObservation)(o)).Value);
                    else if (o is PositionObservation) value = DataTypeStringConverter.FormatPosition(((PositionObservation)(o)).Value);
                    else if (o is StringObservation) value = ((StringObservation)(o)).Value;
                    else throw new NotSupportedException("Unsupported observation data type: " + o.GetType().ToString());
                    string line = string.Format("{0},{1},{2}\r\n", io.ObservationId, o.Timestamp.ToString("o"), value);
                    sb.Append(line);
                }
            }
            return sb.ToString();
        }  
        #endregion
    }
}
