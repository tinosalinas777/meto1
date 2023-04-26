using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodolog1.tp2
{
    //ejercicio 4 del tp2 
    internal class Diccionario :Icoleccionable
    {
        private List<ClaveValor> listaDiccionario;

        public Diccionario()
        {
            this.listaDiccionario = new List<ClaveValor>();
        }
        public List<ClaveValor> getElementos()
        {
            return this.listaDiccionario;
        }
        public void agregar(Comparable clave, object valor )
        {
            ClaveValor v1 = new ClaveValor(clave,valor);

            if(listaDiccionario.Count==0 )
            {
                listaDiccionario.Add(v1);
            }
            else
            {
                foreach(ClaveValor z in listaDiccionario)
                {
                    if (z.getClave().sosIgual(v1.getClave()))
                    {
                        listaDiccionario.Remove(z);
                        break;
                    }
                }
                listaDiccionario.Add((ClaveValor)v1);
            }
        }
        public object? valorDe(Comparable c)
        {
            foreach(ClaveValor clavelista in listaDiccionario)
            {
                if(c == clavelista.getValor())
                {
                    return clavelista.getValor();
                }
            }
            return null;
        }

        public int Cuantos()
        {
            return this.listaDiccionario.Count;
        }

        public Comparable Minimo()
        {
            ClaveValor c = this.listaDiccionario[0];
            foreach(ClaveValor clavelista in listaDiccionario)
            {
                if (((Comparable)clavelista.getValor()).sosMenor((Comparable)c.getValor()))
                {
                    c = clavelista;
                }
            }
            return c.getClave();
        }

        public Comparable Maximo()
        {
            ClaveValor c = this.listaDiccionario[0];
            foreach(ClaveValor clavelista in listaDiccionario)
            {
                if (((Comparable)clavelista.getValor()).sosMayor((Comparable)c.getValor())){

                    c=clavelista;
                }
            }
            return c.getClave();

        }

        public void Agregar(Comparable obj)
        {
            throw new NotImplementedException();
            //implementado a principio de la clase
        }

        public bool Contiene(Comparable obj)
        {
            foreach(ClaveValor clavelista in listaDiccionario)
            {
                if(((Comparable)clavelista.getValor()).sosIgual((Comparable)obj))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
