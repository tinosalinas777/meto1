using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodolog1.tp2
{
    internal class ClaveValor
    {
        private Comparable clave ;
        private object valor;

        public ClaveValor(Comparable a, object b)
        {
            this.clave = a;
            this.valor = b;
        }
        public Comparable getClave()
        {
            return this.clave;
        }
        public void setClave (Comparable clave)
        {
            this.clave = clave;
        }
        public object getValor()
        {
            return valor;
        }
        public void setValor(object valor)
        {
            this.valor = valor;
        }
    }
}
