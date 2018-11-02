using System;
using System.Collections.Generic;
using System.Text;

namespace Masterloop.Core.Types.Settings
{
    public class ExpandedSettingsPackage : SettingsPackage
    {
        public new ExpandedSettingValue[] Values { get; set; }
    }
}
