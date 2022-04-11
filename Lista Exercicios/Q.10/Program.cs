using System;

namespace Q10
{
    /*
    Fácil 10 - Escreva um programa que pergunte o raio de uma circunferência e em seguida mostre o diâmetro, o comprimento e área da circunferência.
    */
    class Program
    {
        static void Main(string[] args)
        {
            
            double raio, area, circ;

            Console.WriteLine("Digite o tamanho do raio deste círculo: ");
            raio = Convert.ToDouble(Console.ReadLine());

            area = Math.PI*raio*raio;

            circ = 2*Math.PI*raio;

            Console.WriteLine($"Área: {area:F2}\nCircunferência: {circ:F2}");

        }
    }
}
