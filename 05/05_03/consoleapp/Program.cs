int y = 0, n = 0, passagiers = 0;
bool trueorfalse = true;
do
{
    System.Console.WriteLine("Y of N: ");
    string input = Console.ReadLine();

    switch (input.ToUpper())
    {
        case "N":
            n++;
            passagiers++;

            break;

        case "Y":
            y++;
            passagiers++;

            break;
    }
if (y == 4 || passagiers == 8)
    {
        trueorfalse = false;
    }

} while (trueorfalse);

System.Console.WriteLine($"Er zijn {passagiers} passagiers. {y} zitten er aan het raam.");