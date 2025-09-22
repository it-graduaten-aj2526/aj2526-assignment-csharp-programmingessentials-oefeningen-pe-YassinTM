int getal1, getal2;

Console.WriteLine("Geef getal 1");
getal1 = int.Parse(Console.ReadLine());

Console.WriteLine("Geef getal 2");
getal2 = int.Parse(Console.ReadLine());

if (getal1 <= getal2)
{
    Console.Write($"{getal2} - {getal1} = {(getal2-getal1)}");
}
else
{
        Console.Write($"{getal1} - {getal2} = {(getal1-getal2)}");

}