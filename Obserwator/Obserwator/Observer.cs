﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    internal abstract class Observer
    {
        public abstract void Update(Subject subject);
    }
}
