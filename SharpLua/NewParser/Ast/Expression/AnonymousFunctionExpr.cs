﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpLua.Ast.Expression
{
    public class AnonymousFunctionExpr : Expression
    {
        public List<Statement.Statement> Body = null;
        public bool IsVararg = false;
        public List<Variable> Arguments = new List<Variable>();
    }
}
