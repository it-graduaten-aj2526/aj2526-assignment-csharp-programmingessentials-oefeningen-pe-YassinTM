System.Console.WriteLine("Coordinaat 1");
int coordinaat1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Coordinaat 2");
int coordinaat2 = int.Parse(Console.ReadLine());

if (coordinaat1 == 0 && coordinaat2 == 0)
{
    System.Console.WriteLine("Punt ligt in de oorsprong.");
}
else if (coordinaat1 >= 0 && coordinaat2 >= 0)
{
    System.Console.WriteLine("Punt ligt in het eerste kwadrant.");
}
else if (coordinaat1 < 0 && coordinaat2 >= 0)
{
    System.Console.WriteLine("Punt ligt in het tweede kwadrant.");
}
else if (coordinaat1 < 0 && coordinaat2 < 0)
{
    System.Console.WriteLine("Punt ligt in het derde kwadrant.");
}
else
{
    System.Console.WriteLine("Punt ligt in het vierde kwadrant.");
}