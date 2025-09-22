int landingsplaats;
Console.Write("Landingsplaats? : ");
landingsplaats = int.Parse(Console.ReadLine());

if (landingsplaats == 1)
{
    Console.WriteLine("0 punten");
}
else if (landingsplaats == 2)
{
Console.WriteLine("20 punten");
}
else if (landingsplaats == 3)
{
Console.WriteLine("50 punten");
}
else if (landingsplaats == 4)
{
Console.WriteLine("100 punten");
}
else
{ 
Console.WriteLine("Iets klopt niet..");
}