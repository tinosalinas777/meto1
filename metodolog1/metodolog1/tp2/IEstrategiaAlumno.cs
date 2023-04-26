﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodolog1.tp2
{
    internal interface IEstrategiaAlumno
    {
        bool sosIgual(Comparable c1, Comparable c2);
        bool sosMenor(Comparable c1, Comparable c2);
        bool sosMayor(Comparable c1, Comparable c2);
    }
}
