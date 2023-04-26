using metodolog1.tp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodolog1
{
    internal class Alumno : Persona
    {
        protected int legajo;
        protected int promedio;
        public IEstrategiaAlumno strategy = new CompararAlumnoPorDni();

        public Alumno(string n, int d, int l, int p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;

        }
        public void setEstrategia(IEstrategiaAlumno e)
        {
            this.strategy = e;

        }
        public int getLegajo()
        {
            return this.legajo;
        }
        public int getPromedio()
        {
            return this.promedio;
        }
        public override bool sosIgual(Comparable a)
        {
            return this.strategy.sosIgual(this,a);
        }
        public override bool sosMayor(Comparable a)
        {
            return this.strategy.sosMayor(this,a);
        }
        public override bool sosMenor(Comparable a)
        {
            return this.strategy.sosMenor(this,a);
        }
    }
}
