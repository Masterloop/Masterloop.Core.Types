using System;

namespace Masterloop.Core.Types.EventLog
{
    public class DeviceEvent
    {
        public DeviceEvent(DateTime timestamp, EventCategoryType category, string title, string body, bool receivedFromDevice = false)
        {
            this.Timestamp = timestamp;
            this.Category = category;
            this.Title = title;
            this.Body = body;
            this.ReceivedFromDevice = receivedFromDevice;
        }

        public DeviceEvent() { }

        public DateTime Timestamp { get; set; }

        public EventCategoryType Category { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public bool ReceivedFromDevice { get; set; }
    }
}
