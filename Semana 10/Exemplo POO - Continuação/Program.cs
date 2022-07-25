// PRORTER ROD

Animal a1 = new Animal();

a1.especie = "Gallus gallus";
a1.qtdDentes = 0;
a1.SetPeso(5);
a1.estaVivo = true;
a1.genero = 'M';

Console.WriteLine($"Espécie: {a1.especie}");
Console.WriteLine($"Genero: {a1.genero}");
Console.WriteLine($"Vivo: {a1.estaVivo}");
Console.WriteLine($"Peso: {a1.GetPeso()}");
Console.WriteLine($"Dentes: {a1.qtdDentes}");

Animal a2 = new Animal();

a2.especie = "Gallus gallus";
a2.qtdDentes = 0;
a2.estaVivo = true;
a2.genero = 'F';

try
{
    a2.SetPeso(-5);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine($"Espécie: {a2.especie}");
Console.WriteLine($"Gênero: {a2.genero}");
Console.WriteLine($"Vivo: {a2.estaVivo}");
Console.WriteLine($"Peso: {a2.GetPeso()}");
Console.WriteLine($"Dentes: {a2.qtdDentes}");

Cachorro c1 = new Cachorro("Canadense", "X");

Galo g1 = new Galo(false, "Galo");
