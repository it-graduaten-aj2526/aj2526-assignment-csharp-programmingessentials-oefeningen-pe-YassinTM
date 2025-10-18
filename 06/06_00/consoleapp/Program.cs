int getal;
int som = 0;
bool istrue;

do
{
    System.Console.WriteLine("Geef een getal: ");
    istrue = int.TryParse(Console.ReadLine(), out getal);
} while (!istrue);

while (getal > 0)
{
    som += getal;
    do
{
    System.Console.WriteLine("Geef een getal: ");
    istrue = int.TryParse(Console.ReadLine(), out getal);
} while (!istrue);
}
System.Console.WriteLine($"Totaal: {som}");