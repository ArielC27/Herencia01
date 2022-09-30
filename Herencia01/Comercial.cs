using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia01
{
    public class Comercial : Empleado
    {
        public double Comision { get; set; }
        public override decimal Plus()
        {
            if (Edad > 20 && Comision > 300)
            {
                Salario = Salario + plus;
            }
            return Salario;
        }
    }
}
