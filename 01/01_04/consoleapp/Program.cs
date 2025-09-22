int vastBedrag = 23, nationaal, internationaal;
double oproepkosten = 0.12;
double percentage = 1.21;
Console.Write("Hoeveel nationale oproepen? :");
nationaal = int.Parse(Console.ReadLine());

Console.Write("Hoeveel internationale oproepen? :");
internationaal = int.Parse(Console.ReadLine());

double tussenbedrag = (vastBedrag + ((internationaal + nationaal) * oproepkosten));
double Totaalbedrag = tussenbedrag * 1.21;

Console.WriteLine($"Totaal te betalen: {Totaalbedrag}");
