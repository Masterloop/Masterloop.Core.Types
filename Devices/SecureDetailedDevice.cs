namespace Masterloop.Core.Types.Devices
{
    public class SecureDetailedDevice : DetailedDevice
    {
        public string PreSharedKey { get; set; }

        public string HTTPAuthenticationKey
        {
            get
            {
                return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(MID.ToString() + ":" + PreSharedKey));
            }
        }
    }
}
