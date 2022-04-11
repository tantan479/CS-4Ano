using System;

namespace Q24
{

    /*
    Difícil 24 - Faça um programa para o cálculo de uma folha de pagamento de uma empresa que paga por hora de trabalho. Os descontos do imposto de renda dependem do salário bruto (conforme tabela abaixo). 

	De 0,00 até 1.903,98 – isento;
	De 1.903,99 até 2.826,65 – 7,5%;
	De 2.826,66 até 3.751,05 – 15%;
	De 3.751,06 até 4.664,68 – 22,5%;
	A partir de 4.664,68 - 27,5%.

    Há também um desconto de 3% para o sindicato, independente da faixa salarial. Outra informação importante é o valor do FGTS recolhido pela empresa, que corresponde a 11% do salário bruto e que não é descontado do funcionário (é a empresa que deposita). O salário líquido corresponde ao salário bruto menos os descontos. O programa deverá pedir ao usuário o valor da sua hora, a quantidade de horas trabalhadas no mês e realizar os cálculos. Por fim, o programa deverá mostrar uma saída semelhante à saída a seguir:

    Horas trabalhadas: 		180
    Valor da hora: 			R$ 20,00
    Salário bruto (180 * 220):	R$ 3600,00
    ( – ) IR (15%): 		R$ 540,00
    ( – ) Sindicato (3%): 		R$ 108,00
    FGTS ( 11%): 			R$ 121,00
    Total de descontos: 		R$ 648,00
    Salário líquido:		R$ 2.952,00 
    */

    class Program
    {
        static void Main(string[] args)
        {
            
            int hs;
            double vh, desc, sl, sb, fgts, sind, ir, irp=0;


            Console.WriteLine("Informe as horas trabalhadas: ");
            hs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor de sua hora: ");
            vh = Convert.ToInt32(Console.ReadLine());

            sb = hs*vh;
            fgts = sb*0.11;
            sind = sb*0.03;


            if(sb <= 1903.98){
                ir = 0;
            }else if(sb <= 2826.65){
                irp = 0.075;
                ir = sb*irp;
            }else if(sb <= 3751.05){
                irp = 0.15;
                ir = sb*irp;
            }else if(sb <= 4664.68){
                irp = 0.225;
                ir = sb*irp;
            }else{
                irp = 0.275;
                ir = sb*irp;
            }

            desc = sind + ir;
            sl = sb - desc;

            Console.WriteLine(
                $"Horas Trabalhadas:   {hs:C}\nSalário Bruto:       {sb:C}\nIR ({irp*100}%):            {ir:C}\nSindicato (3%):      {sind:C} \nFGTS (11%):          {fgts:C}\nTotal de Descontos   {desc:C} \nSalário Líquido:     {sl:C}"
            );



        }
    }
}
