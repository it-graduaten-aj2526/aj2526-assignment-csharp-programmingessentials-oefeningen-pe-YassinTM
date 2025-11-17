// // //Creation of method
// // //DOES NOT RUN YET 

// // //VOID IS RETURN DATATYPE 
// // void ToonNaam(string naam, string voornaam)
// // {
// //     Console.WriteLine($"{naam}\n{voornaam}");
// // }
// // //int is return type
// // int Optellen(int getal1, int getal2)
// // {
// //    //to return something use return 
// //  return    getal1 + getal2;
// // }

// // ToonNaam("Moumni", "Yassin");
// // //Optellen(1,2) geeft 3 maar print niets, geen writeline gebruikt
// // int som = Optellen(1,2);

// // //of
// // System.Console.WriteLine(Optellen(1,2));
// //----
// string ReadStringNotEmpty()
// {
//     string output;
//     do
//     {
//         System.Console.WriteLine("Geef een string in: ");
//         output = Console.ReadLine();

//     } while (output == "");
//     return output;
// }
// ReadStringNotEmpty();


// //MAG NIET
// //variable=x
// //methode{
// //variable++
// //}

// //GEBRUIK PARAMETERS
// //variable=x
// //variable = methode(variable)
// //methode(PARAMETER){}
int getal, totaal = 0;
int ReadNumber()
{
    int inputgetal;
    do
    {
        System.Console.Write("Geef een geheel getal: ");
    } while (!int.TryParse(Console.ReadLine(), out inputgetal));
    return inputgetal;
}

bool isNegative(int number)
{
    if (number <= 0)
    {
        return true;
    }
    return false;
}

do
{
getal = ReadNumber();
if (getal > 0)
{
    totaal += getal;
}
    
} while (!isNegative(getal));




System.Console.WriteLine($"Totaal = {totaal}");