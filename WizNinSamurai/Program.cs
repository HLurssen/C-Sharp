Human Human1 = new Human ("Bill");
Human Human2 = new Human ("Attacker");
Ninja Ninja1 = new Ninja ("Po");
Samurai MasterOogway = new Samurai ("MasterOogway");
Wizard Harry = new Wizard("Harry");

Ninja1.Attack (Human1);
Ninja1.Steal (Human2);
MasterOogway.Attack(Ninja1);
MasterOogway.Attack(Ninja1);

Console.WriteLine("Po's HP is now" + Ninja1);
Console.WriteLine(Human1.Health);
Console.WriteLine(Ninja1.Health);
Console.WriteLine(Human1.Health);
Console.WriteLine($"{Human1.Name} being attacked");
Human2.Attack(Human1);
Console.WriteLine(Human1.Health);
Console.WriteLine("Samurai's health is low: " + MasterOogway.Health);
MasterOogway.Meditate();
Console.WriteLine("The Samurai Meditates their health is now: " + MasterOogway.Health);
Console.WriteLine(Harry.Attack(Human1));