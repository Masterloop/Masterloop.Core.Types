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
            return string.Format("{0},{1},{2}", value.Latitude.ToString(CultureInfo.InvariantCulture), value.Longitude.ToString(CultureInfo.InvariantCulture), value.Altitude.ToString(CultureInfo.InvariantCulture));
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
            if (double.TryParse(value, System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out d))
            {
                return d;
            }
            throw new ArgumentException("Invalid double value: " + value);
        }
        public static int ParseIntegerValue(string value)
        {
            int i;
            if (Int32.TryParse(value, System.Globalization.NumberStyles.Integer, CultureInfo.InvariantCulture, out i))
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
                    if (double.TryParse(values[0], System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out lat) &&
                        double.TryParse(values[1], System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out lon))
                    {
                        if (lat >= -90.0 && lat <= 90.0 && lon >= -180.0 && lon <= 180.0)
                        {
                            return new Position()
                            {
                                Latitude = lat,
                                Longitude = lon,
                                Altitude = double.NaN
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
                    if (double.TryParse(values[0], System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out lat) &&
                        double.TryParse(values[1], System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out lon) &&
                        double.TryParse(values[2], System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out alt))
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
            }
            throw new ArgumentException("Invalid position value: " + value);
        }
        #endregion
    }
}
