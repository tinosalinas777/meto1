using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodolog1
{
    internal interface Icoleccionable
    {
        public int Cuantos();
        public Comparable Minimo();

        public Comparable Maximo();
        public void Agregar(Comparable obj);
        public bool Contiene(Comparable obj);
    }
}
