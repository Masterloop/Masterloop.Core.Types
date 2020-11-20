using System;
using System.Globalization;

namespace Masterloop.Core.Types.Base
{
    public class DataTypeStringConverter
    {
        #region Formatters
        public static string FormatBoolean(bool value)
        {
            return (value) ? "1" : "0";
        }

        public static string FormatDouble(double value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        public static string FormatInteger(int value)
        {
            return value.ToString();
        }

        public static string FormatPosition(Position value)
        {
            if (value.Altitude.HasValue)
            {
                if (value.DOP.HasValue)
                {
                    return string.Format("{0},{1},{2},{3}", value.Latitude.ToString(CultureInfo.InvariantCulture), value.Longitude.ToString(CultureInfo.InvariantCulture), value.Altitude.Value.ToString(CultureInfo.InvariantCulture), value.DOP.Value.ToString(CultureInfo.InvariantCulture));
                }
                else
                {
                    return string.Format("{0},{1},{2}", value.Latitude.ToString(CultureInfo.InvariantCulture), value.Longitude.ToString(CultureInfo.InvariantCulture), value.Altitude.Value.ToString(CultureInfo.InvariantCulture));
                }
            }
            else
            {
                return string.Format("{0},{1}", value.Latitude.ToString(CultureInfo.InvariantCulture), value.Longitude.ToString(CultureInfo.InvariantCulture));
            }
        }

        public static string FormatStatistics(DescriptiveStatistics value)
        {
            string s =
                $"{value.Count}," +
                $"{value.Mean.ToString(CultureInfo.InvariantCulture)}," +
                $"{value.Minimum.ToString(CultureInfo.InvariantCulture)}," +
                $"{value.Maximum.ToString(CultureInfo.InvariantCulture)},";
            if (value.From.HasValue)
            {
                s += $"{value.From.Value.ToUniversalTime():o}";
            }
            s += ",";
            if (value.To.HasValue)
            {
                s += $"{value.To.Value.ToUniversalTime():o}";
            }
            s += ",";
            if (value.StdDev.HasValue)
            {
                s += value.StdDev.Value.ToString(CultureInfo.InvariantCulture);
            }
            s += ",";
            if (value.Median.HasValue)
            {
                s += value.Median.Value.ToString(CultureInfo.InvariantCulture);
            }
            return s;
        }
        #endregion

        #region Parsers
        public static bool ParseBooleanValue(string value)
        {
            if (value.Length == 1)
            {
                if (value[0] == '1')
                {
                    return true;
                }
                else if (value[0] == '0')
                {
                    return false;
                }
            }
            throw new ArgumentException("Invalid boolean value: " + value);
        }
        public static double ParseDoubleValue(string value)
        {
            double d;
            if (double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out d))
            {
                return d;
            }
            throw new ArgumentException("Invalid double value: " + value);
        }
        public static int ParseIntegerValue(string value)
        {
            int i;
            if (Int32.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out i))
            {
                return i;
            }
            throw new ArgumentException("Invalid integer value: " + value);
        }
        public static Position ParsePositionValue(string value)
        {
            string[] values = value.Split(',');
            if (values != null)
            {
                if (values.Length == 2 && values[0] != null && values[0].Length > 0 && values[1] != null && values[1].Length > 0)  //lat,lon
                {
                    double lat, lon;
                    if (double.TryParse(values[0], NumberStyles.Float, CultureInfo.InvariantCulture, out lat) &&
                        double.TryParse(values[1], NumberStyles.Float, CultureInfo.InvariantCulture, out lon))
                    {
                        if (lat >= -90.0 && lat <= 90.0 && lon >= -180.0 && lon <= 180.0)
                        {
                            return new Position()
                            {
                                Latitude = lat,
                                Longitude = lon
                            };
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("Position value out of range: " + value);
                        }
                    }
                }
                else if (values.Length == 3 && values[0] != null && values[0].Length > 0 && values[1] != null && values[1].Length > 0 && values[2] != null && values[2].Length > 0)  // lat,lon,alt
                {
                    double lat, lon, alt;
                    if (double.TryParse(values[0], NumberStyles.Float, CultureInfo.InvariantCulture, out lat) &&
                        double.TryParse(values[1], NumberStyles.Float, CultureInfo.InvariantCulture, out lon) &&
                        double.TryParse(values[2], NumberStyles.Float, CultureInfo.InvariantCulture, out alt))
                    {
                        if (lat >= -90.0 && lat <= 90.0 && lon >= -180.0 && lon <= 180.0)
                        {
                            return new Position()
                            {
                                Latitude = lat,
                                Longitude = lon,
                                Altitude = alt
                            };
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("Position value out of range: " + value);
                        }
                    }
                }
                else if (values.Length == 4 && values[0] != null && values[0].Length > 0 && values[1] != null && values[1].Length > 0 && values[2] != null && values[2].Length > 0 && values[3] != null && values[3].Length > 0)  // lat,lon,alt,dop
                {
                    double lat, lon, alt, dop;
                    if (double.TryParse(values[0], NumberStyles.Float, CultureInfo.InvariantCulture, out lat) &&
                        double.TryParse(values[1], NumberStyles.Float, CultureInfo.InvariantCulture, out lon) &&
                        double.TryParse(values[2], NumberStyles.Float, CultureInfo.InvariantCulture, out alt) &&
                        double.TryParse(values[3], NumberStyles.Float, CultureInfo.InvariantCulture, out dop))
                    {
                        if (lat >= -90.0 && lat <= 90.0 && lon >= -180.0 && lon <= 180.0)
                        {
                            return new Position()
                            {
                                Latitude = lat,
                                Longitude = lon,
                                Altitude = alt,
                                DOP = dop
                            };
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("Position value out of range: " + value);
                        }
                    }
                }
            }
            throw new ArgumentException("Invalid position value: " + value);
        }
        public static DescriptiveStatistics ParseStatisticsValue(string value)
        {
            string[] values = value.Split(',');
            if (values != null && values.Length == 8)
            {
                DescriptiveStatistics stats = new DescriptiveStatistics();
                stats.Count = int.Parse(values[0]);
                stats.Mean = double.Parse(values[1], CultureInfo.InvariantCulture);
                stats.Minimum = double.Parse(values[2], CultureInfo.InvariantCulture);
                stats.Maximum = double.Parse(values[3], CultureInfo.InvariantCulture);
                if (values[4] != null && values[4].Length > 0) stats.From = DateTime.Parse(values[4], CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
                if (values[5] != null && values[5].Length > 0) stats.To = DateTime.Parse(values[5], CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
                if (values[6] != null && values[6].Length > 0) stats.StdDev = double.Parse(values[6], CultureInfo.InvariantCulture);
                if (values[7] != null && values[7].Length > 0) stats.Median = double.Parse(values[7], CultureInfo.InvariantCulture);
                return stats;
            }
            else
            {
                throw new ArgumentException("Invalid statistics value: " + value);
            }
        }
        #endregion
    }
}
