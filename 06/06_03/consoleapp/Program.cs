string teamnaam, sym1, sym2;
bool Ploegnaamcheck, lcheck, bcheck;
int l, b;


do
{
    System.Console.WriteLine("Ploegnaam?");
    teamnaam = Console.ReadLine();
} while (teamnaam.Length < 5);

while(teamnaam != "*****"){

    do
    {
        System.Console.WriteLine("Symbool1: ");
        sym1 = Console.ReadLine();
    } while (sym1.Length > 1);

    do
    {
        System.Console.WriteLine("Symbool2: ");
        sym2 = Console.ReadLine();
    } while (sym2.Length > 1 || sym2 == sym1);

    do
    {
        do
        {
            System.Console.WriteLine("lengte: ");
            lcheck = int.TryParse(Console.ReadLine(), out l);
        } while (!lcheck);
    } while (l < 4);



    do
    {
        do
        {
            System.Console.WriteLine("breedte: ");
            bcheck = int.TryParse(Console.ReadLine(), out b);
        } while (!bcheck);
    } while (b < (l / 2));


    System.Console.WriteLine($"{teamnaam}");
    for (int i = 0; i < l; i++)
    {

        if (i % 2 == 0)
        {
            for (int a = 0; a < b; a++)
            {
                System.Console.Write($"{sym1}");
            }
            System.Console.WriteLine();
        }
        else
        {
            for (int a = 0; a < b; a++)
            {
                System.Console.Write($"{sym2}");
            }
            System.Console.WriteLine();
        }

    }
    do
{
    System.Console.WriteLine("Ploegnaam?");
    teamnaam = Console.ReadLine();
} while (teamnaam.Length < 5);


}
