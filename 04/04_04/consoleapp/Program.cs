System.Console.WriteLine("symbool 1: ");
string symbool1 = Console.ReadLine();

System.Console.WriteLine("symbool 2: ");
string symbool2 = Console.ReadLine();

System.Console.WriteLine("Lengte : ");
int lengte = int.Parse(Console.ReadLine());

System.Console.WriteLine("Breedte : ");
int breedte = int.Parse(Console.ReadLine());




for (int i = 0; i < lengte; i++)
{
    if (i % 2 == 0)
    {
        for (int a = 0; a < breedte; a++)
        {
            System.Console.Write(symbool1);
        }
        System.Console.WriteLine();
    }
    else
    {
        for (int a = 0; a < breedte; a++)
        {
            System.Console.Write(symbool2);
        }
        System.Console.WriteLine();

    }
}