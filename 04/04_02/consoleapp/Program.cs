System.Console.WriteLine("Naam: ");
string naam = Console.ReadLine();

System.Console.WriteLine("Geluksgetal: ");
int geluksgetal = int.Parse(Console.ReadLine());

System.Console.Write(geluksgetal + " ");
for (int i = 0; i < geluksgetal; i++)
{
System.Console.Write(naam + " ");
}