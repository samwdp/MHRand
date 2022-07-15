string[] weapons =
{
    "Gunlance",
    "Charge Blade",
    "Lance",
    "Great Sword",
    "SnS",
    "Dual Blades",
    "Long Sword",
    "Hammer",
    "Switch Axe",
    "Hunting Horn",
    "Insect Glaive",
    "Bow",
    "LBg",
    "Hbg"
};

Random r = new();
bool running = true;

Console.WriteLine(@"
Press Enter to select a new weapon
Press Escape to exit app
");

while (running)
{
    var key = Console.ReadKey();
    if (key.Key == ConsoleKey.Escape) running = false;
    if (key.Key == ConsoleKey.Enter)
        Console.WriteLine(weapons[r.Next(0, weapons.Length)]);
}
