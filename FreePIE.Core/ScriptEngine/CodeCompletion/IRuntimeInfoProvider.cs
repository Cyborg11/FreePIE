﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreePIE.Core.Model;

namespace FreePIE.Core.ScriptEngine.CodeCompletion
{
    public interface IRuntimeInfoProvider
    {
        IEnumerable<ExpressionInfo> AnalyzeExpression(IEnumerable<Token> tokens);
    }
}
