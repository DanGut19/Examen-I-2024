using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_I_2024
{
    internal interface lNota
    {
        public double CalcularNotaFinal();
        public double CalcularNotaFinal(double Parcial1, double Parcial2, double Parcial3);
        public string MensajeNota();
        public string MensajeNota(double Parcial1, double Parcial2, double Parcial3);

    }
}
