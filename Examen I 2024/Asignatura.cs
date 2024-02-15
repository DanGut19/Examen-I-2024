using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_I_2024
{
    internal class Asignatura : Alumno
    {
        public string Nombre { get; set; }
        public string Horario { get; set; }
        public string Docente { get; set; }

        public override void InformacionAlumno()
        {
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Nombre del Alumno:{Nombre}");
            Console.WriteLine($"Numero de cuenta del Alumno:{NumeroCuenta}");
            Console.WriteLine($"Email del Alumno:{Email}");
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        public void MostrarAsignatura()
        {
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Nombre de la Asignatura:{Nombre}");
            Console.WriteLine($"Horario de la Asignatura:{Horario}");
            Console.WriteLine($"Nombre del Docente:{Docente}");
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
