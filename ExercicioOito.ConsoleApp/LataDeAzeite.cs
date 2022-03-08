using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOito.ConsoleApp
{
    internal class LataDeAzeite
    {
        public double altura;
        public double raio;
        public double volume;

        const double pi = 3.14;

        public double CalcularVolumeLataAzeite(double altura, double raio)
        {
            volume = pi * (raio * raio) * altura;
            return volume;
        }
    }
}