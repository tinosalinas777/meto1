using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodolog1.tp2
{
    internal class CompararAlumnoPorDni : IEstrategiaAlumno
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getDNI() == ((Alumno)c2).getDNI();
            
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getDNI() > ((Alumno)c2).getDNI();
            
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getDNI() < ((Alumno)c2).getDNI();
            
        }
    }
}
