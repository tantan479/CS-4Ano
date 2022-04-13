using System;

namespace Semana_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Console.BackgroundColor = ConsoleColor.Cyan;
            
            Console.Clear();
           
            int op = 1;

            do{
            
                Console.WriteLine("\nPressione qualquer tecla");
                Console.ReadKey();
                Console.Clear();
                
                Console.WriteLine("\n------Programas------");
                Console.WriteLine("1-Calculadora de IMC");
                Console.WriteLine("2- Maior número");
                Console.WriteLine("3- Positivo ou Negativo");
                Console.WriteLine("4- Verificar sexo");
                Console.WriteLine("5- Verificar consoante ou vogal");
                Console.WriteLine("6- Verificar notas");
                Console.WriteLine("7- Verificar produto");
                Console.WriteLine("8- Verifica turno");
                Console.WriteLine("9- Calcular e verificar");
                Console.WriteLine("10- Vericador de assassino");
                Console.WriteLine("0- Pare");



                Console.WriteLine("Escolha:");
                op = Convert.ToInt32(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        Calcula_imc();
                        break;
                    case 2:
                        Ver_maior();
                        break;
                    case 3:
                        Pos_Neg();
                        break;
                    case 4:
                        Ver_sex();
                        break;
                    case 5:
                        Ver_alf();
                        break;
                    case 6:
                        Notas();
                        break;
                    case 7:
                        Prod3();
                        break;
                    case 8:
                        Turno();
                        break;
                    case 9:
                        Calc_vef();
                        break;
                    case 10:
                        Vef_ass();
                        break;
                    default:
                        Console.WriteLine("Escolha Inválida");
                        break;
                }
            }while(op != 0);

            Console.Clear();

        }

        static void Calcula_imc()
        {
            //Programa calculador de IMC.

            double alt, peso;

            Console.WriteLine("------Calculadora de IMC------");
            Console.WriteLine("Digite a sua altura:");
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

        static void Ver_maior()
        {
            Console.WriteLine("Digite um número:");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite mais um número:");
            var num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            
            Console.WriteLine("O maior número é: ");

            if(num1 > num2){
                Console.Write(num1);
            }else{
                Console.Write(num2);
            }
        }

        static void Pos_Neg()
        {
            Console.WriteLine("Digite um número:");
            var num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O número é: ");

            if(num >= 0){
                Console.Write("Positivo");
            }else{
                Console.Write("Negativo");
            }
        }

        static void Ver_sex()
        {
            Console.WriteLine("Digite F ou M:");
            var s = Console.ReadLine().ToUpper();

            Console.Clear();
            
            if(s == "M"){
                Console.WriteLine("Masculino");
            }else if(s == "F"){
                Console.WriteLine("Feminino");
            }else{
                Console.WriteLine("Sexo inválido");
            }
        }

        static void Ver_alf()
        {
            Console.WriteLine("Digite uma letra:");
            var letra = Console.ReadLine().ToLower();

            Console.Clear();

            if(letra =="a" | letra == "e" | letra == "i" | letra == "o" | letra == "u"){
                Console.WriteLine("Temos uma vogal");
            }else if (Char.IsLetter(letra[0])){
                Console.WriteLine("Temos uma consoante");
            }else{
                Console.WriteLine("Inválido");
            }
        }

        static void Notas()

        {
           
           double n1, n2, m;
           
            Console.WriteLine("Digite a nota 1:");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 2:");
            n2 = Convert.ToDouble(Console.ReadLine());

            m = (n1+n2)/2;

            if(m==10){
                Console.WriteLine("Aprovado com louvou");
            }else if(m>=7){
                Console.WriteLine("Aprovado");
            }else{
                Console.WriteLine("Reprovado");
            }
            
        }

        static void Prod3()
        {
            
            double min=0;
            double[] p = {0, 0, 0};
            
            Console.WriteLine("Digite o valor do produto 1:");
            p[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto 2:");
            p[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto 3:");
            p[2] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            
            for(int i = 0; i<3; i++){
                if(i==0){
                    min=p[0];
                }
                if(p[i] < min){
                    min = p[i];
                }
            }

            Console.WriteLine($"Compre o produto de valor: {min:C}");

        }

        static void Turno()
        {
            Console.WriteLine("Digite M (matutino) ou V (vespertino) ou N (noturno):");
            var t = Console.ReadLine();

            Console.Clear();

            if(t == "M"){
                Console.WriteLine("Bom dia");
            }else if(t == "V"){
                Console.WriteLine("Boa tarde");
            }else if(t == "N"){
                Console.WriteLine("Boa noite");
            }else{
                Console.WriteLine("Turno Inválido");
            }
        }

        static void Calc_vef()
        {

            Console.WriteLine("Digite um número: ");
            var num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite mais um número: ");
            var num2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Realize uma operação:");
            Console.WriteLine("1- Somar\n2- Multiplicar\n3- Subtrair\n4- Dividir");

            var op = Convert.ToDouble(Console.ReadLine());

            Double res=0;

            switch(op)
            {
                case 1:
                    res = num1 + num2;
                    break;
                case 2:
                    res = num1 * num2;
                    break;
                case 3:
                    res = num1 - num2;
                    break;
                case 4:
                    res = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Escolha inválida");
                    break;
            }

            Console.WriteLine($"O resultado é {res}");
            
            if(res%2 == 0){
                Console.WriteLine(" Número Par");
            }else{
                Console.WriteLine(" Número Impar");
            }

            if(res >= 0){
                Console.WriteLine(" e positivo");
            }else{
                Console.WriteLine(" e negativo");
            }

        }

        static void Vef_ass()
        {
            
            Console.Clear();

            int soma=0;

            String[] r = {"f", "f", "f", "f", "f"};
            
            Console.WriteLine("Responda S(sim) e N(não)");
            
            
            Console.WriteLine("Você telefonou para a vítima?");
            r[0] = Console.ReadLine().ToUpper();

            Console.WriteLine("Você esteve no local do crime?");
            r[1] = Console.ReadLine().ToUpper();

            Console.WriteLine("Mora perto da vítima?");
            r[2] = Console.ReadLine().ToUpper();

            Console.WriteLine("Você devia para a vítima?");
            r[3] = Console.ReadLine().ToUpper();
 
            Console.WriteLine("Você trabalhou para a vítima?");
            r[4] = Console.ReadLine().ToUpper();


            Console.Clear();


            for(int i = 0; i<5; i++){
                if(r[i] == "S"){
                    soma++;
                }
            }

            if(soma == 5){
                Console.WriteLine("Assassino");
            }else if(soma == 4 | soma == 3){
                Console.WriteLine("Cumplice");
            }else if (soma == 2){
                Console.WriteLine("Suspeito");
            }else{
                Console.WriteLine("Inocente");
            }


        }
    }
}
