class Samurai : Human {
    public Samurai (string name) : base (name)
    {
        Health = 200;
    }

    public override int Attack(Human Taget)
    {
        base.Attack(Target);
        if (AttributeTargets.Health < 50)
        {
            Target.Health = 0;
            Console.WriteLine(Name + "folded" + Target.Name);
        }
        return Target.Health;
    }
    public void Meditate()
    {
        Health = 200;
    }
}