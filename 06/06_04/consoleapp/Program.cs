int tafel;
bool tafelnum;
do
{

    System.Console.WriteLine("geef een tafel in");
    tafelnum = int.TryParse(Console.ReadLine(), out tafel);
} while (!tafelnum);

while(tafel != 0)
{
    for (int i = 0; i < 10; i++)
    {
        System.Console.WriteLine($"{i + 1} x {tafel} = {(i + 1) * tafel} ");
    }

    do
{

    System.Console.WriteLine("geef een tafel in");
    tafelnum = int.TryParse(Console.ReadLine(), out tafel);
} while (!tafelnum);
}