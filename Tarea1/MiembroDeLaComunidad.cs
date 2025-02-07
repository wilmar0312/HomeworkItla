using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCommunitySystem
{
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public int Id { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Miembro: {Nombre}, ID: {Id}");
        }
    }

}
