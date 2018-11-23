using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Masterloop.Core.Types.EventLog
{
    public class ReportedDeviceEvent
    {
        public EventCategoryType Category { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }
    }
}
