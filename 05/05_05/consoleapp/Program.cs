int input, punten = 0;
bool notvalidnumber;

for (int i = 0; i < 3; i++)
{


    do
    {
        System.Console.Write("geef een nummer in: ");
        int.TryParse(Console.ReadLine(), out input);
        switch (input)
        {
            case 1:
                notvalidnumber = false;
                punten = punten + 0;
                break;
            case 2:
                notvalidnumber = false;
                punten = punten + 20;
                break;
            case 3:
                notvalidnumber = false;
                punten = punten + 50;
                break;
            case 4:
                notvalidnumber = false;
                punten = punten + 100;

                break;
            default:
                notvalidnumber = true;
                break;
        }


    } while (notvalidnumber);
}
System.Console.WriteLine($"U hebt {punten} punten behaald");