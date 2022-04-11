namespace Q12
{

    /* Escreva um programa que pergunte o dia, o mês e o ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Para simplificar, considere que todos os meses possuem 30 dias.
    */

    class Program
    {
        static void Main(string[] args)
        {
            
            int i=0;
            string[] k = {"dia", "mês", "ano"};
            int[] dat = {0, 0, 0};
            int ifs = 0;

            foreach (var item in k)
            {
                Console.WriteLine($"Qual o {item} do seu aniversário?");
                dat[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }

            if(dat[0] > 30 || dat[0] <= 0)
                ifs++;
            
            if(dat[1] > 12 || dat[0] <= 0)
                ifs++;

            if(dat[2] > DateTime.Now.Year)
                ifs++;

            if(ifs!=0)
                Console.WriteLine("Anivesário inválido");
            else
                Console.WriteLine("Aniversário válido");



        }
    }
}