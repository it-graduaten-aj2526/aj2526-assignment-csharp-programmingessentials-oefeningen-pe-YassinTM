using System.Collections.Concurrent;

string teamname, sym1, sym2;
int h, l;
bool condition, exit = true;

while (exit)
{
    do
    {
        System.Console.WriteLine("team name? min 5 char");
        teamname = Console.ReadLine();
    } while (teamname.Length < 5 && teamname != "*****");

    if (teamname != "*****")
    {
        do
        {
            System.Console.WriteLine("symbol 1?");
            sym1 = Console.ReadLine();
        } while (sym1.Length != 1);

        do
        {
            System.Console.WriteLine("symbol 2?");
            sym2 = Console.ReadLine();
        } while (sym2.Length != 1 || sym2 == sym1);

        do
        {
            System.Console.WriteLine("lengte?");
            condition = int.TryParse(Console.ReadLine(), out l);
        } while (!condition || l < 4);

        do
        {
            System.Console.WriteLine("breedte?");
            condition = int.TryParse(Console.ReadLine(), out h);
        } while (!condition || h < (l/2));

        System.Console.WriteLine(teamname);
        for (int i = 0; i < h; i++)
        {
            if (i%2==0)
            {
                for (int i2 = 0; i2 < l; i2++)
                {
                    System.Console.Write(sym1);
                }
                System.Console.WriteLine();
            }
            else
            {
                for (int i2 = 0; i2 < l; i2++)
                {
                    System.Console.Write(sym2);
                }
                System.Console.WriteLine();
            }
        }
    }
    else
    {
        exit = false;
    }
}