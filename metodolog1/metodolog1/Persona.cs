using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodolog1
{
    internal class Persona : Comparable
    {
        protected string nombre;
        protected int dni;
        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;

        }

        public string getNombre()
        {
            return nombre;

        }
        public int getDNI()
        {
            return dni;
        }

        public virtual bool sosIgual(Comparable a)
        {
            return this.getDNI() == ((Persona)a).getDNI();
        }

        public virtual bool sosMenor(Comparable a)
        {
            if (this.getDNI() > ((Persona)a).getDNI())
            {
                return true;

            }
            return false;
        }

        public virtual bool sosMayor(Comparable a)
        {
            if (this.getDNI() < ((Persona)a).getDNI())
            {
                return true;

            }
            return false;
        }
    }
}
