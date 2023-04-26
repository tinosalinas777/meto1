using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodolog1
{
    internal class Numero : Comparable
    {
        private int valor;

        public Numero(int v)
        {
            this.valor = v;
        }

        public int getValor()
        {
            return this.valor;
        }
        public bool sosIgual(Comparable a)
        {
            return this.getValor() == ((Numero)a).getValor();
        }

        public bool sosMayor(Comparable a)
        {
            return this.getValor() > ((Numero)a).getValor();
        }

        public bool sosMenor(Comparable a)
        {
            return this.getValor() < ((Numero)a).getValor();
        }
    }
}
