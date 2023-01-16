using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagnostica
{
    internal class Variable
    {
        private double ingreso;
        private int empleados;

        public void Pempleados(int empleados)
        {
            this.empleados = empleados;
        }
        public int Mempleados()
        {
            return this.empleados;
        }

        public void Pingresos(double ingreso)
        {
            this.ingreso = ingreso;
        }
        public double Mingresos()
        {
            return this.ingreso;
        }

      

    }
}
