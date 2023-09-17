using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Herencia__
{
    public class ExAlumno : IMiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public String CarreraEgresada { get; set; }

        public void BuscarTrabajo() { }

    }
}
