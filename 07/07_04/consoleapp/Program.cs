using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

string antwoord, shortword = "", longword = "";
List<string> woordlijst = [];
int longest = 0, shortest = int.MaxValue, current;


do
{
    System.Console.WriteLine("Geef een woord in: ");
    antwoord = Console.ReadLine();
    if (!string.IsNullOrEmpty(antwoord))
    {
        woordlijst.Add(antwoord);
    }

} while (!string.IsNullOrEmpty(antwoord));


foreach (string woord in woordlijst)
{
    current = woord.Length;
    if (current < shortest)
    {
        shortest = current;
    }
    if (current > longest)
    {
        longest = current;
    }

}
foreach (string item in woordlijst)
{
    if (item.Length == shortest)
    {
        shortword = item;
    }
    else if (item.Length == longest)
    {
        longword = item;
    }
}

System.Console.WriteLine($"Het langste woord is {longword}\nHet kortste woord is {shortword}\nDe som van de posities is {woordlijst.IndexOf(shortword) + woordlijst.IndexOf(longword)}");
