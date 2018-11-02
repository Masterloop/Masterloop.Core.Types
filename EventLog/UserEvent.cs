using System;

namespace Masterloop.Core.Types.EventLog
{
    public class UserEvent
    {
        public UserEvent(DateTime timestamp, EventCategoryType category, string title, string body)
        {
            this.Timestamp = timestamp;
            this.Category = category;
            this.Title = title;
            this.Body = body;
        }

        public UserEvent() { }

        public DateTime Timestamp { get; set; }

        public EventCategoryType Category { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }
    }
}
