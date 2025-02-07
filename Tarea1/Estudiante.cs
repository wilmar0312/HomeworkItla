using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCommunitySystem
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public double Promedio { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Promedio: {Promedio}");
        }
    }
}
