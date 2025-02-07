using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCommunitySystem
{
    public class Empleado : MiembroDeLaComunidad
    {
        public double Salario { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Salario: {Salario}");
        }
    }

}
