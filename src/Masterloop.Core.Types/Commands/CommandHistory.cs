using System;

namespace Masterloop.Core.Types.Commands
{
    public class CommandHistory : Command
    {
        public string OriginApplication { get; set; }

        public string OriginAccount { get; set; }

        public string OriginAddress { get; set; }

        public string OriginReference { get; set; }

        public DateTime? DeliveredAt { get; set; }

        public bool? WasAccepted { get; set; }

        public int? ResultCode { get; set; }

        public string Comment { get; set; }

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
