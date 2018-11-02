using System;
using System.Collections.Generic;
using System.Text;

namespace Masterloop.Core.Types.Commands
{
    public class CommandHistory : Command
    {
        public DateTime? DeliveredAt { get; set; }

        public bool? WasAccepted { get; set; }

        public CommandStatus Status
        {
            get
            {
                if (WasAccepted.HasValue)
                {
                    if (WasAccepted.Value)
                    {
                        return CommandStatus.Executed;
                    }
                    else
                    {
                        return CommandStatus.Rejected;
                    }
                }
                else
                {
                    if (ExpiresAt.HasValue && DateTime.UtcNow > ExpiresAt)
                    {
                        return CommandStatus.Expired;
                    }
                    else
                    {
                        return CommandStatus.Sent;
                    }
                }
            }
        }
    }
}
