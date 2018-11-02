using System;

namespace Masterloop.Core.Types.LiveConnect
{
    public class CommandSubscription<T>
    {
        public readonly string MID;
        public readonly int CommandId;
        public readonly Action<string, T> CommandHandler;

        public CommandSubscription(string mid, int commandId, Action<string, T> commandHandler)
        {
            MID = mid;
            CommandId = commandId;
            CommandHandler = commandHandler;
        }
    }
}
