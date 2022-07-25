Cachorro c1 = new Cachorro(5, 1, true, 'f', "Canadense", "Adolfo");
//Console.WriteLine(c1); // Isso implicita o c1.ToString()

Cachorro c2 = new Cachorro(0.3, 0, true, 'M', "Capiotis", "Estal");

Galo g1 = new Galo(5, 1, true, false, "Galo");

List<Animal> animais = new List<Animal>();
animais.Add(c1);
animais.Add(c2);
animais.Add(g1);

foreach(var animal in animais)
{
    Console.WriteLine(animal); // IDentifiquem-se
}

