﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreePIE.GUI.Events
{
    public class ScriptUpdatedEvent : ScriptEvent
    {
        public ScriptUpdatedEvent(string script) : base(script) { }
    }
}
