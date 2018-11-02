using System;
using System.Collections.Generic;
using System.Text;

namespace Masterloop.Core.Types.Commands
{
    public enum CommandStatus
    {
        Sent,
        Expired,
        Executed,
        Rejected
    }
}
