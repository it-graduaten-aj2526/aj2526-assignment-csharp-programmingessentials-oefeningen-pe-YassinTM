string Evenement, answer, naam;
List<string> naamlist = new List<string>();
bool conditional = true;

//evenement vragen, mag niet empty - if empty loop

//check ja of nee input

//check if answer is ja or nee
//if ja ask name and add name to list go back up
//if nee  
//if list empty say Er zijn geen aanwezigen voor event!
//if list NOT empty say aanwezigen voor evenement: naamlist!


 do
    {
        System.Console.WriteLine("evenement: ");
        Evenement = Console.ReadLine();
    } while (string.IsNullOrEmpty(Evenement));

do
{
    //ja nee input check
   

    do
    {
        System.Console.WriteLine("lijst toevoegen? ja of nee");
        answer = Console.ReadLine();
        if (answer.ToUpper() == "JA" || answer.ToUpper() == "NEE")
        {
            conditional = false;
        }
        else
        {
            conditional = true;
        }
    } while (conditional);
    //end input check


    if (answer.ToUpper() == "JA")
    {
        System.Console.WriteLine("Geef naam in: ");
        naam = Console.ReadLine();
        naamlist.Add(naam + "\n");
        conditional = true;
    }
    else
    {
        if (naamlist.Count == 0)
        {
            System.Console.WriteLine($"Er zijn geen aanwezigen voor {Evenement}!");
        }
        else
        {
            System.Console.WriteLine($"Aanwezigen voor {Evenement}: \n");
            for (int i = 0; i < naamlist.Count; i++)
                {
                    Console.WriteLine(naamlist[i]);
                }   
        }
        conditional = false;
    }

} while (conditional);