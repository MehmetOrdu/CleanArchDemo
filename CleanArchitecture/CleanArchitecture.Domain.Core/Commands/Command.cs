﻿using CleanArchitecture.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Core.Commands
{
    public abstract class Command:Message
    {
        public DateTime Timestemp { get;protected set; }
        protected Command()
        {
            Timestemp = DateTime.Now;
        }
    }
}