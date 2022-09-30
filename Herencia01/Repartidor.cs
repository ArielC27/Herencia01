using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Herencia01
{
    internal class Repartidor : Empleado
    {
        public string? Zona { get; set; }
        public override decimal Plus()
        {
            if (Zona == "3" && Edad < 35)
            {
                Salario = Salario + plus;
            }
            return Salario;
        }
    }
}
