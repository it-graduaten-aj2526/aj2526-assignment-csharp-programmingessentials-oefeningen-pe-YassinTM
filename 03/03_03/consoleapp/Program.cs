int getal1, getal2, getal3;
string code, getalAlsString;

System.Console.WriteLine("Geef getal 1 in");
getalAlsString = Console.ReadLine();
getal1 = int.Parse(getalAlsString);

System.Console.WriteLine("Geef getal 2 in");
getalAlsString = Console.ReadLine();
getal2 = int.Parse(getalAlsString);

System.Console.WriteLine("Geef getal 3 in");
getalAlsString = Console.ReadLine();
getal3 = int.Parse(getalAlsString);

System.Console.WriteLine("Geef een code A B C of D in: ");
code = Console.ReadLine().ToUpper();

switch (code)
{
    case "A":
        System.Console.WriteLine($"Uitkomst: {getal1 + getal2 + getal3}");
        break;
    case "B":
        System.Console.WriteLine($"Uitkomst: {getal1 * getal3}");
        break;
    case "C":
        System.Console.WriteLine($"Uitkomst: {getal3 - getal2}");
        break;
    case "D":
        if (getal1 > 0)
        {
            Console.WriteLine($"Uitkomst: {(int)Math.Sqrt(getal1)}");
        }
        else
        {
            Console.WriteLine("Foutieve invoer.");
        }
        break;
    default:
        int grootste = Math.Max(getal1, Math.Max(getal2, getal3));
        Console.WriteLine($"Uitkomst: {grootste}");
        break;
}