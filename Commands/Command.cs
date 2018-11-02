using System;

namespace Masterloop.Core.Types.Commands
{
    public class Command
    {
        public int Id { get; set; }

        public DateTime Timestamp { get; set; }

        public DateTime? ExpiresAt { get; set; }

        public CommandArgument[] Arguments { get; set; }
    }
}
