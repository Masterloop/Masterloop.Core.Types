using System;

namespace Masterloop.Core.Types.Base
{
    public class MessageRoutingKey
    {
        public static string GenerateDeviceObservationRoutingKey(string MID, int observationId)
        {
            return string.Format("{0}.O.{1}", MID, observationId);
        }

        public static string GenerateDeviceCommandRoutingKey(string MID, int commandId, DateTime timestamp)
        {
            return string.Format("{0}.C.{1}.{2}", MID, commandId, timestamp.Ticks);
        }

        public static string GenerateDeviceCommandResponseRoutingKey(string MID, int commandId, DateTime timestamp)
        {
            return string.Format("{0}.CR.{1}.{2}", MID, commandId, timestamp.Ticks);
        }

        public static string GeneratePulseRoutingKey(string MID)
        {
            return string.Format("{0}.P", MID);
        }

        public static string GeneratePulseRoutingKey(string MID, int sourceId)
        {
            return string.Format("{0}.P.{1}", MID, sourceId);
        }

        public static string GenerateSystemNotificationRoutingKey(int categoryId)
        {
            return string.Format("SYS.{0}", categoryId);
        }

        public static bool IsDeviceObservation(string routingKey)
        {
            string[] elements = routingKey.Split('.');
            if (elements != null && elements.Length > 2)
            {
                return elements[1] == "O";
            }
            else
            {
                return false;
            }
        }

        public static bool IsDeviceObservationPackage(string routingKey)
        {
            string[] elements = routingKey.Split('.');
            if (elements != null && elements.Length == 3)
            {
                return elements[1] == "OP";
            }
            else
            {
                return false;
            }
        }

        public static bool IsDeviceCommand(string routingKey)
        {
            string[] elements = routingKey.Split('.');
            if (elements != null && elements.Length > 2)
            {
                return elements[1] == "C";
            }
            else
            {
                return false;
            }
        }

        public static bool IsDeviceCommandResponse(string routingKey)
        {
            string[] elements = routingKey.Split('.');
            if (elements != null && elements.Length > 2)
            {
                return elements[1] == "CR";
            }
            else
            {
                return false;
            }
        }

        public static bool IsDevicePulse(string routingKey)
        {
            string[] elements = routingKey.Split('.');
            if (elements != null && elements.Length == 2)
            {
                return elements[1] == "P";
            }
            else
            {
                return false;
            }
        }

        public static bool IsApplicationPulse(string routingKey)
        {
            string[] elements = routingKey.Split('.');
            if (elements != null && elements.Length == 3)
            {
                return elements[1] == "P";
            }
            else
            {
                return false;
            }
        }

        public static bool IsSystemNotification(string routingKey)
        {
            string[] elements = routingKey.Split('.');
            if (elements != null && elements.Length == 2)
            {
                return elements[0] == "SYS";
            }
            else
            {
                return false;
            }
        }

        public static string ParseMID(string routingKey)
        {
            return ParseFirstString(routingKey);
        }

        public static int ParseObservationId(string routingKey)
        {
            if (string.IsNullOrEmpty(routingKey)) return 0;
            string[] elements = routingKey.Split('.');
            if (elements.Length < 3) return 0;
            return Int32.Parse(elements[elements.Length - 1]);
        }

        public static string ParseObservationPackageType(string routingKey)
        {
            if (string.IsNullOrEmpty(routingKey)) return null;
            string[] elements = routingKey.Split('.');
            if (elements.Length < 3) return null;
            return elements[2];
        }

        public static int ParseCommandId(string routingKey)
        {
            if (string.IsNullOrEmpty(routingKey)) return 0;
            string[] elements = routingKey.Split('.');
            if (elements.Length < 4) return 0;
            return Int32.Parse(elements[2]);
        }

        public static DateTime ParseCommandTimestamp(string routingKey)
        {
            string s = ParseLastString(routingKey);
            long ticks = long.Parse(s);
            return new DateTime(ticks, DateTimeKind.Utc);
        }

        public static int ParsePulseId(string routingKey)
        {
            string s = ParseLastString(routingKey);
            return Int32.Parse(s);
        }

        public static int ParseSystemNotification(string routingKey)
        {
            if (string.IsNullOrEmpty(routingKey)) return 0;
            string[] elements = routingKey.Split('.');
            if (elements.Length != 2) return 0;
            return Int32.Parse(elements[1]);
        }

        private static string ParseFirstString(string routingKey)
        {
            if (string.IsNullOrEmpty(routingKey)) return string.Empty;
            string[] elements = routingKey.Split('.');
            if (elements.Length < 1) return string.Empty;
            return elements[0];
        }

        private static string ParseLastString(string routingKey)
        {
            if (string.IsNullOrEmpty(routingKey)) return string.Empty;
            string[] elements = routingKey.Split('.');
            if (elements.Length < 1) return string.Empty;
            return elements[elements.Length - 1];
        }
    }
}
