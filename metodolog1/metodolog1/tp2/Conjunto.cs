using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodolog1.tp2
{
    internal class Conjunto : Icoleccionable
    {
        private List<Comparable> elementos;

        public Conjunto()
        {
            this.elementos = new List<Comparable>();
        }
        public List<Comparable> getElementos()
        {
            return this.elementos;
        }
        public bool pertenece(Comparable a)
        {
            foreach (Comparable c in this.getElementos()) 
            {
                if (c.sosIgual(a)){
                    return true;
                }
            }
            return false;
        }
        public void agregar(Comparable a)
        {
            if(!pertenece(a))
            {
                elementos.Add(a);
            }
        }
        //ejercicio 5 tp2
        public int Cuantos()
        {
            return this.elementos.Count;
        }

        public Comparable Minimo()
        {
            Comparable c = this.elementos[0];
            for(int i=1;i < this.Cuantos(); i++)
            {
                if (elementos[i].sosMenor((Comparable)c))
                {
                    c = this.elementos[i];
                }
            }
            return c;
        }

        public Comparable Maximo()
        {
            Comparable c = this.elementos[0];
            for(int i=1;i < this.Cuantos(); i++)
            {
                if (this.elementos[i].sosMayor(((Comparable)c)))
                {
                    c = this.elementos[i];
                }

            }
            return c;
        }

        public void Agregar(Comparable obj)
        {
            throw new NotImplementedException();
        }

        public bool Contiene(Comparable obj)
        {
            for(int i =0;i < this.Cuantos(); i++)
            {
                if (this.elementos[i].sosIgual(obj))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
