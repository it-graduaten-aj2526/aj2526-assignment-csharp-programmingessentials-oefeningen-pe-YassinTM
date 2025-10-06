//version 2
string letter;
System.Console.WriteLine("Geef een letter: ");
letter = Console.ReadLine().ToLower();

switch (letter)
{
    case "a":
        System.Console.WriteLine("Klinker.");
        break;
    case "e":
        System.Console.WriteLine("Klinker.");
        break;
    case "i":
        System.Console.WriteLine("Klinker.");
        break;
    case "o":
        System.Console.WriteLine("Klinker.");
        break;
    case "u":
        System.Console.WriteLine("Klinker.");
        break;
    default:
        System.Console.WriteLine("Medeklinker");
        break;
}
// The switch statement compares the value of 'letter' with each case.
// If a match is found, the corresponding code block runs.
// If no case matches, the 'default' block runs.
// the break tells the code to exit the switch statement if the case has been matched;