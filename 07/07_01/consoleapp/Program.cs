int intcijfer, posgetallen = 0, negsom = 0;
string inputcijfer;
List<int> cijferlijst = [];


do
{
    System.Console.WriteLine("Geef een cijfer in");
    inputcijfer = Console.ReadLine();

    if (int.TryParse(inputcijfer, out intcijfer))
    {
        cijferlijst.Add(intcijfer);
    }

} while (!string.IsNullOrEmpty(inputcijfer));

foreach (int item in cijferlijst)
{
    if (item > 0)
    {
        posgetallen++;
    }
    else if (item < 0)
    {
        negsom += item;
    }
}
System.Console.WriteLine($"Aantal positief: {posgetallen}\nNegatieve som: {negsom}");
//