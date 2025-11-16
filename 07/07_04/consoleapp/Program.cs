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
        shortword = woord;
    }
    if (current > longest)
    {
        longest = current;
        longword = woord;
    }

}

System.Console.WriteLine($"Het langste woord is {longword}\nHet kortste woord is {shortword}\nDe som van de posities is {woordlijst.IndexOf(shortword) + woordlijst.IndexOf(longword)}");
//