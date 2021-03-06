﻿using System;
using Paramore.Brighter.Eventsourcing.Attributes;
using Paramore.Brighter.Tests.CommandProcessors.TestDoubles;

namespace Paramore.Brighter.Tests.EventSourcing.TestDoubles
{
    internal class MyStoredCommandToFailHandler : RequestHandler<MyCommandToFail>
    {
        [UseCommandSourcing(1, onceOnly: true, contextKey: typeof(MyStoredCommandToFailHandler), timing: HandlerTiming.Before)]
        public override MyCommandToFail Handle(MyCommandToFail command)
        {
            throw new NotImplementedException();
        }
    }
}
