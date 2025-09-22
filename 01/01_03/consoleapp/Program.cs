int volwassenen, kinderen;

Console.Write("Hoeveel Volwassenen? : ");
volwassenen = int.Parse(Console.ReadLine());

Console.Write("Hoeveel kinderen? : ");
kinderen = int.Parse(Console.ReadLine());

double teBetalen = (volwassenen * 10) + (kinderen * 7.5);



Console.WriteLine($"Totaal te betalen: {teBetalen}");