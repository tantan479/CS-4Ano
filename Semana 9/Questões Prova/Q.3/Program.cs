﻿Console.WriteLine("Digite um valor inteiro: "); 
string entnum = Console.ReadLine(); 
int num = Convert.ToInt32(entnum); 
if (num > 0) Console.WriteLine("Positivo"); 
else if (num < 0) Console.WriteLine("Negativo"); 
else Console.WriteLine("Número zero");
