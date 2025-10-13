int getal1, getal2;
bool istrue;

System.Console.WriteLine("Getal: ");
istrue = int.TryParse(Console.ReadLine(), out getal1);
while (!istrue)
{
    System.Console.WriteLine("Getal: ");
    istrue = int.TryParse(Console.ReadLine(), out getal1);
}

System.Console.WriteLine("Getal 2: ");
istrue = int.TryParse(Console.ReadLine(), out getal2);
while (!istrue)
{
    System.Console.WriteLine("Getal: ");
    istrue = int.TryParse(Console.ReadLine(), out getal2);
}

if (getal1 > getal2)
{
    System.Console.WriteLine($"{getal1} - {getal2} = {getal1 - getal2}");
}
else
{
        System.Console.WriteLine($"{getal2} - {getal1} = {getal2 - getal1}");

}
