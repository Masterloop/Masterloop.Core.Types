namespace Masterloop.Core.Types.LiveConnect
{
    public class BindingKey
    {
        public static string GenerateWildcardKey()
        {
            return "#";
        }

        public static string GenerateDeviceBindingKey(string MID)
        {
            return string.Format("{0}.#", MID);
        }

        public static string GenerateObservationBindingKey(int observationId)
        {
            return string.Format("*.O.{0}", observationId);
        }

        public static string GenerateObservationBindingKey()
        {
            return string.Format("*.O.#");
        }

        public static string GenerateCommandBindingKey()
        {
            return string.Format("*.C.#");
        }

        public static string GenerateCommandResponseBindingKey()
        {
            return string.Format("*.CR.#");
        }

        public static string GenerateCommandBindingKey(int commandId)
        {
            return string.Format("*.C.{0}.*", commandId);
        }

        public static string GenerateDeviceObservationBindingKey(string MID)
        {
            return string.Format("{0}.O.#", MID);
        }

        public static string GenerateDeviceCommandBindingKey(string MID)
        {
            return string.Format("{0}.C.#", MID);
        }

        public static string GenerateDeviceCommandResponseBindingKey(string MID)
        {
            return string.Format("{0}.CR.#", MID);
        }

        public static string GenerateCommandResponseBindingKey(int commandId)
        {
            return string.Format("*.CR.{0}.*", commandId);
        }

        public static string GeneratePulseBindingKey()
        {
            return "*.P";
        }

        public static string GenerateDevicePulseBindingKey(string MID)
        {
            return string.Format("{0}.P", MID);
        }

        public static string GenerateDeviceApplicationsPulseBindingKey(string MID)
        {
            return string.Format("{0}.P.#", MID);
        }

        public static string GenerateApplicationsPulseBindingKey()
        {
            return string.Format("*.P.#");
        }

        public static string GeneratePulseBindingKey(int pulseId)
        {
            return string.Format("*.P.{0}", pulseId);
        }
    }
}
