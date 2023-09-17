using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Herencia__
{
    public abstract class Empleado : IMiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public decimal Salario { get; set; }

        public abstract void trabajar();
    }
}
