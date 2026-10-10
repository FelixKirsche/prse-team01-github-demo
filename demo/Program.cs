Console.WriteLine("=== Developer-Motivationsgenerator ===");
Console.WriteLine();

Console.Write("Dein Name: ");
string name = Console.ReadLine() ?? "Developer";

string[] motivations =
[
    "It works on my machine!",
    "99 Bugs im Code, fix einen, 127 Bugs im Code.",
    "Das ist kein Bug, das ist ein Feature!",
    "Schon mal einen Neustart versucht?",
    "Freitag um 16:59 Uhr noch schnell deployen!"
];

string motivation = motivations[Random.Shared.Next(motivations.Length)];

Console.WriteLine();
Console.WriteLine($"Hallo {name}!");
Console.WriteLine($"Developer-Weisheit des Tages: {motivation}");