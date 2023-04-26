using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodolog1.tp2
{
    internal class CompararAlumnoPorNombre : IEstrategiaAlumno
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getNombre() == ((Alumno)c2).getNombre();
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getNombre().Length > ((Alumno)c2).getNombre().Length;
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getNombre().Length < ((Alumno)c2).getNombre().Length;
        }
    }
}
