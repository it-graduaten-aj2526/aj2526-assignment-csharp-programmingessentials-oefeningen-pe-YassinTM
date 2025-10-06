System.Console.WriteLine("getal1");
int getal1 = int.Parse(Console.ReadLine()); 

System.Console.WriteLine("getal2");
int getal2 = int.Parse(Console.ReadLine());

for (int i = getal1; i >= getal2; i--)
{
    System.Console.Write(i);
    if (i > getal2)
    {
        System.Console.Write(" * ");
    }
}