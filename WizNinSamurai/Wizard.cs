class Wizard
{
    public Wizard(string name) : base(name, intelligence, dexterity, health)
    {
        Intelligence = 25;
        Health = 50;
    }
    public override int Attack(Human target)
    {
        int dmg = Intelligence * 5;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.name} for {dmg} damage.");
        Console.WriteLine($"{Name} healed {target.Name} for {Heal} health.");
        return target.Health;
    }
}