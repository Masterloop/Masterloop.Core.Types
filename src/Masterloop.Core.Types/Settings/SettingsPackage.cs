using System;

namespace Masterloop.Core.Types.Settings
{
    public class SettingsPackage
    {
        public string MID { get; set; }

        public DateTime LastUpdatedOn { get; set; }

        public SettingValue[] Values { get; set; }
    }
}
