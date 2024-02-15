using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_I_2024
{
    internal class Nota : lNota
    {
        public double Parcial1 { get; set; }
        public double Parcial2 { get; set; }
        public double Parcial3 { get; set; }

        public Nota(double Parcial1, double Parcial2, double Parcial3) {

            this.Parcial1 = Parcial1;
            this.Parcial2 = Parcial2;
            this.Parcial3 = Parcial3;

        }

        public double CalcularNotaFinal()
        {
            return (Parcial1 + Parcial2 + Parcial3) / 3;
        }

        public double CalcularNotaFinal(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }
        public string MensajeNota()
        {
            return $"MensajeNota: {MensajeNota()}%";
        }

        public string MensajeNota(double a, double b, double c)
        {
            return $"MensajeNota: {MensajeNota()}%";
        }
    }
}
