//version 2
int getal1, getal2, getal3, getal4, optelling, vermenigvuldiging;

Console.Write("Geef getal 1 in: ");
getal1 = int.Parse(Console.ReadLine());

Console.Write("Geef getal 2 in: ");
getal2 = int.Parse(Console.ReadLine());

Console.Write("Geef getal 3 in: ");
getal3 = int.Parse(Console.ReadLine());

Console.Write("Geef getal 4 in: ");
getal4 = int.Parse(Console.ReadLine());

optelling = getal1 + getal3;
vermenigvuldiging = getal2 * getal4;

Console.Write($"Optelling : {optelling} \nVermenigvuldiging : {vermenigvuldiging}");