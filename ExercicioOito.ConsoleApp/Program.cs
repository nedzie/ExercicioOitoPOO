using System;

namespace ExercicioOito.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataDeAzeite soya = new LataDeAzeite();
            Console.Write("Informe a altura do cilindro: \n> ");
            soya.altura = double.Parse(Console.ReadLine());
            Console.Write("Informe o raio do cilindro: \n> ");
            soya.raio = double.Parse(Console.ReadLine());
            soya.volume = soya.CalcularVolumeLataAzeite(soya.altura, soya.raio);

            Console.WriteLine("O volume desta belíssima lata de azeite é de: " + soya.volume.ToString("#.##") + "m³");
            Console.ReadKey();
        }
    }
}