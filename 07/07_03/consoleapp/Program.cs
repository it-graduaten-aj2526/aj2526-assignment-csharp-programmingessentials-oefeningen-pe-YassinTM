string input;
int inputcijfer;
List<int> cijferlijst = [];



while (true)
{
    do
    {
        System.Console.WriteLine("Geef een cijfer in: ");
        input = Console.ReadLine();
    } while (!int.TryParse(input, out inputcijfer) && !string.IsNullOrEmpty(input));

    if (string.IsNullOrEmpty(input))
    {
        break;
    }
    else
    {
            cijferlijst.Add(inputcijfer);

    }
}

cijferlijst.Sort();
System.Console.WriteLine($"Laagste getal: {cijferlijst.First()}\nHoogste getal: {cijferlijst.Last()}");