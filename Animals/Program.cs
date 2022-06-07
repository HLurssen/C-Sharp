// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// First instance of an animal
Animal Dog = new Animal("Dog", 60.2, "Omnivore", true);
Animal Bear = new Animal("Bear", 60.2, "Omnivore");
Animal Fish = new Animal("Fish", 60.2, "Fish diet. Idk");
Animal Bird = new Animal("Bird", 60.2, "Seeds?? Maybe? And words.");
Animal Coyote = new Animal("Coyote", 60.2);

Console.WriteLine(Dog.Species);
Console.WriteLine(Bear.isFriendly);
Console.WriteLine(Coyote.Diet);

Dog.makeNoise("Bark");

Mammal lion = new Mammal("Lion", 120.5, "carnivore", false);

Console.WriteLine(lion.Species);
Console.WriteLine(lion.hasFur);
lion.makeNoise("Roar");