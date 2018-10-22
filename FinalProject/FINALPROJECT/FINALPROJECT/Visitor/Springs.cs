﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECT;

namespace Visitor
{
    public class Springs : IVisitable
    {
        public void AcceptVisitor(IWidgetVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
