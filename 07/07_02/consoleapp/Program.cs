List<int> cijferlijst = [];
string antwoord;

int inputcijfer = 0;

while (true)
{
    System.Console.WriteLine("Wil je een cijfer toevoegen aan de list?");
    antwoord = Console.ReadLine();

    if (antwoord.ToLower() == "ja")
    {
        do
        {
            System.Console.Write("Geef een cijfer in: ");
        } while (!int.TryParse(Console.ReadLine(), out inputcijfer));
        cijferlijst.Add(inputcijfer);
    }
    else if (antwoord.ToLower() == "nee")
    {
        break;
    }

}
cijferlijst.Sort();

System.Console.WriteLine($"Laagste cijfer: {cijferlijst.First()}\nHoogste cijfer: {cijferlijst.Last()}\nGemiddelde: {cijferlijst.Average()}");
//