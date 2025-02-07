using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCommunitySystem.SubClases
{
    public class Maestro : Docente
    {
        public int AñosExperiencia { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Años de experiencia: {AñosExperiencia}");
        }
    }
}
