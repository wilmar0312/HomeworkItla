using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCommunitySystem.SubClases
{
    public class Administrador : Docente
    {
        public string NivelAdministrativo { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Nivel Administrativo: {NivelAdministrativo}");
        }
    }
}
