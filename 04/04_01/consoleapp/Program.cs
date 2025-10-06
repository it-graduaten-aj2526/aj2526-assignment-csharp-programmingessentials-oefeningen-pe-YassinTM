
int getal = 0;
for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine("Geef een getal in");
    int inputgetal = int.Parse(Console.ReadLine());
    getal = getal + inputgetal;

}
System.Console.WriteLine($"Som: {getal}");