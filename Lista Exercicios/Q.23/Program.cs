using System; 

namespace Q23
{

    /*
    Difícil 23 - As Organizações Tabajara resolveram dar um aumento de salário aos seus colaboradores e lhe contrataram para desenvolver o programa que calculará os reajustes. Faça um programa que recebe o salário de um colaborador e reajuste esse salário segundo o seguinte critério, baseado no salário atual:

	Salários até R$ 280,00 (incluindo): aumento de 20%;
	Salários entre R$ 280,00 e R$700,00: aumento de 15%;
	Salários entre R$ 700,00 e R$ 1500,00: aumento de 10%;
	Salários de R$ 1500,00 em diante: aumento de 5%.

	Após o aumento ser realizado, informe na tela:

	a. O salário antes do reajuste;
	b. O percentual de aumento aplicado;
	c. O valor do aumento;
	d. O novo salário (após o aumento).
    */

    class Program
    {
        static void Main(string[] args)
        {
            
            double s0, s1, r;
            

            Console.WriteLine("Digite o seu salário: ");
            s0 = Convert.ToDouble(Console.ReadLine());

            if(s0 <= 280){
                r = 0.2;
                s1 = s0*r + s0;
            }else if(s0 < 700){
                r = 0.15;
                s1 = s0*r + s0;
            }else if(s0 < 1500){
                r = 0.1;
                s1 = s0*r + s0;
            }else{
                r = 0.05;
                s1 = s0*r + s0;
            }

            Console.WriteLine($"Salário Anterior: {s0}");
            Console.WriteLine($"Percentual de Aumento: {r*100}%");
            Console.WriteLine($"Valor do aumento: {s1-s0}");
            Console.WriteLine($"Salário pós-aumento: {s1}");


        }
    }
}

