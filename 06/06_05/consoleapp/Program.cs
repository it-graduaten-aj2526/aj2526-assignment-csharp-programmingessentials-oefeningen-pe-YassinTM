string naam, overzicht = "";
int score, totaalscore = 0, aantal = 0;
bool isscorenum, endloop = true;



System.Console.WriteLine("Naam?");
naam = Console.ReadLine();

if (string.IsNullOrEmpty(naam))
{
    System.Console.WriteLine("Geen aanwezigen");

}
else
{
    do
    {
        System.Console.WriteLine("cijfer");
        isscorenum = int.TryParse(Console.ReadLine(), out score);
    } while (!isscorenum);
    overzicht = overzicht + naam + $" ({score})\n";
    totaalscore = totaalscore + score;
    aantal++;

    do
    {
        System.Console.WriteLine("Naam?");
        naam = Console.ReadLine();
        if (string.IsNullOrEmpty(naam))
        {
            System.Console.WriteLine(overzicht);
            endloop = false;
        }
        else
        {
            do
            {
                System.Console.WriteLine("cijfer");
                isscorenum = int.TryParse(Console.ReadLine(), out score);
            } while (!isscorenum);
            overzicht = overzicht + naam + $" ({score})\n";
            totaalscore = totaalscore + score;
                    aantal++;



            endloop = true;
        }


    } while (endloop);
    System.Console.WriteLine($"Gemiddelde: {totaalscore/aantal}");




}

