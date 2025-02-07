using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCommunitySystem
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        public DateTime FechaGraduacion { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Fecha de Graduación: {FechaGraduacion.ToShortDateString()}");
        }
    }

}
