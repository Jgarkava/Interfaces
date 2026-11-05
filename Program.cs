using InterfacesDemo.Classes;
using InterfacesDemo.Interfaces;

bool running = true;

while (running)
{
    Console.WriteLine("\n=== Main Menu ===");
    Console.WriteLine("1. Run Animals");
    Console.WriteLine("2. Run Warrior");
    Console.WriteLine("3. Run Combat & Healing");
    Console.WriteLine("4. Run Explicit Interfaces");
    Console.WriteLine("5. Run All");
    Console.WriteLine("6. Exit");
    Console.Write("Select an option: ");

    string? choice = Console.ReadLine()?.Trim();
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            RunAnimals();
            break;

        case "2":
            RunWarrior();
            break;

        case "3":
            RunCombatAndHealing();
            break;

        case "4":
            RunExplicitInterfaces();
            break;

        case "5":
            RunAnimals();
            Console.WriteLine();
            RunWarrior();
            Console.WriteLine();
            RunCombatAndHealing();
            Console.WriteLine();
            RunExplicitInterfaces();
            break;

        case "6":
            running = false;
            Console.WriteLine("Exiting program...");
            break;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

void RunAnimals()
{
    IAnimal[] animals = [
        new Dog(),
        new Cat()
    ];

    foreach (var animal in animals)
    {
        animal.Speak();
    }
}

void RunWarrior()
{
    Warrior warrior = new Warrior
    {
        Name = "Aragorn",
        Health = 100,
        AttackPower = 25
    };

    warrior.Attack();
    warrior.Defend();
    warrior.TakeDamage(10);
}

void RunCombatAndHealing()
{
    ICombatant[] fighters = [
        new Warrior { Name = "Aragorn", Health = 100, AttackPower = 25 },
        new Mage { Name = "Merlin", Health = 80, AttackPower = 40 }
    ];

    foreach (var fighter in fighters)
    {
        fighter.Attack();
        fighter.Defend();
    }

    if (fighters[1] is Mage mage)
    {
        mage.Heal(30);
    }
}

void RunExplicitInterfaces()
{
    Knight knight = new Knight();

    IAttack attack = knight;
    attack.Attack();

    IDefend defend = knight;
    defend.Attack();
}