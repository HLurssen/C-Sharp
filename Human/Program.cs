Human Human1 = new Human ("Bill");
Human Human2 = new Human ("Attacker");

Console.WriteLine(Human1.Health);
Console.WriteLine($"{Human1.Name} being attacked");
Human2.Attack(Human1);
Console.WriteLine(Human1.Health);
