using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia01
{
    public abstract class Empleado
    {
        public readonly int plus = 400;
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public decimal Salario { get; set; }
        public abstract decimal Plus();
        
    }
}
