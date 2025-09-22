
//Declaratie van var
using System.Security.Cryptography.X509Certificates;

/**
//Eigenschappen
//Console.Title = "Yassin Moumni";
//Console.ForegroundColor = ConsoleColor.Green;

//Variabelen
string naam = "Yassin";
int nummer = 7;
double kommagetal = 7.7;
bool isWaar = true;
//Meerdere variabelen
string voornaam, achternaam;

//Assign een variabele
voornaam = Console.ReadLine();

//Assign een int
int leeftijd = int.Parse(Console.ReadLine());
//of
int leeftijd2 = Convert.ToInt32(Console.ReadLine());
//Console.readline is altijd een string
//--------------
Console.WriteLine("Wat is je naam?");
string naam = Console.ReadLine();
Console.WriteLine("Wat is je leeftijf?");
int leeftijd = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Registratie ontvangen");
Console.WriteLine($"Naam: {naam}");
Console.WriteLine($"Leeftijd: {leeftijd}");
//String in de text "" moet $ van voor en variable inside {}
//Ook mogelijk is "Leeftijd: " + leeftijd

int a = 10;
int b = 3;
string c = "4";
Console.WriteLine(a + b + c);
//geeft a + b =13 en dan write 4 dus 134


int a = 10;
int b = 3;
double resultaat = a / b; //REMEMBER RECHTSE WAARDE WORDT IN DE LINKSE GEZET
Console.WriteLine(resultaat);
// Geeft geen kommagetal, omdat a (int) gedeeld door b (int) eerst een geheel getal oplevert (integer deling).
// Het resultaat van a / b is 3 (geen 3.33), want beide zijn int. Pas daarna wordt het omgezet naar double.
// Oplossing: maak minstens één van de getallen double, bijvoorbeeld: double resultaat = (double)a / b;


int a = 10;
int b = 8;

b += a
//zelfde als
b = a + b

Console.WriteLine("test");
**/
int kortezijde, langezijde, omtrek, oppervlakte;


Console.Write("Wat is de korte zijde? ");
kortezijde = int.Parse(Console.ReadLine());

Console.Write("Wat is de lange zijde? ");
langezijde = int.Parse(Console.ReadLine());

omtrek = 2 * kortezijde + 2 * langezijde;
oppervlakte = kortezijde * langezijde;

Console.WriteLine($"De omtrek is {omtrek} en oppervlakte is {oppervlakte}");



