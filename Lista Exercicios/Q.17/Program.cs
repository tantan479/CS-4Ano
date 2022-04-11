using System;

namespace Q17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double alt, peso;

            Console.WriteLine("------Calculadora de IMC------");
            Console.WriteLine("Digite a sua altura(x,yz):");
            alt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o seu peso:");
            peso = Convert.ToDouble(Console.ReadLine());

            double imc = peso/(alt*alt);

            Console.WriteLine("Pressione qualquer tecla");
            Console.ReadKey();
            Console.Clear();
            

            Console.Write($"imc:{imc:F2} / ");

            if(imc < 18.5){
                Console.WriteLine("Peso baixo");
            }else if(imc <25){
                Console.WriteLine("Peso normal");
            }else if(imc<30){
                Console.WriteLine("Sobrepeso");
            }else if(imc<35){
                Console.WriteLine("Obesidade");
            }else if(imc<40){
                Console.WriteLine("Obesidade severa");
            }else{
                Console.WriteLine("Obesidade morbida");    
            }

        }
    }
}
