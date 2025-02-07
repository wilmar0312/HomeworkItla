using POOCommunitySystem.SubClases;
using POOCommunitySystem;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista de miembros de la comunidad
        List<MiembroDeLaComunidad> comunidad = new List<MiembroDeLaComunidad>();

        // Agregar diferentes tipos de miembros
        comunidad.Add(new Estudiante { Nombre = "Wil", Id = 1, Promedio = 9.9 });
        comunidad.Add(new Administrador { Nombre = "Cristiano", Id = 2, Salario = 50000, NivelAdministrativo = "Gerente" });
        comunidad.Add(new Maestro { Nombre = "Juan", Id = 3, Salario = 60000, Materia = "Software", AñosExperiencia = 1 });
        comunidad.Add(new ExAlumno { Nombre = "Robin", Id = 4, FechaGraduacion = new DateTime(2024, 8, 20) });

        // Mostrar información de cada miembro
        foreach (var miembro in comunidad)
        {
            miembro.MostrarInformacion();
            Console.WriteLine();
        }
    }
}
