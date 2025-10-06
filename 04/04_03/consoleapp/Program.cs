System.Console.Write("Positief cijfer: ");
double positiefgetal = double.Parse(Console.ReadLine());

for (double i = positiefgetal; i >= 1; i--)
{
    double kwadraat = i * i;
    System.Console.WriteLine(kwadraat);
}