class Animal 
{
    // Establish attributes
    // Words used to describe an item
    public string Species;
    public double Weight;
    public string Diet;
    public bool isFriendly;

// This is the constructor
    public Animal(string species, double weight, string diet)
    {
        Species = species;
        Weight = weight;
        Diet = diet;
        isFriendly = false;
    }
    public Animal(string species, double weight, string diet, bool isFr)
    {
        Species = species;
        Weight = weight;
        Diet = diet;
        isFriendly = isFr;
    }
    public Animal(string species, double weight)
    {
        Species = species;
        Weight = weight;
        Diet = "Omnivore";
    }

    // Methods (functions). Things an animal can do.

    public void makeNoise(string sound)
    {
        Console.WriteLine(sound);
    }
}