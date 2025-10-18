string input, zin = "Op de stoel ligt een zonnehoed en peperkoek";
int attempt = 0;
bool conditioning = true;

System.Console.WriteLine("Op de stoel ligt een zonnehoed en peperkoek");
do
{
    input = Console.ReadLine();
    attempt++;
    if (input == zin)
    {
        conditioning = false;
    }

} while (conditioning);

if (attempt == 1)
{
    System.Console.WriteLine($"Je had {attempt} poging nodig!");
}
else
{
    System.Console.WriteLine($"Je had {attempt} pogingen nodig!");
}