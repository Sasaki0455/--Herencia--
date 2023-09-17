using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Herencia__
{
    class Program
    {
        interface IMiembroDeLaComunidad
        {
            string Nombre { get; set; }
            string Apellido { get; set; }
            int Edad { get; set; }
        }
    }
}
