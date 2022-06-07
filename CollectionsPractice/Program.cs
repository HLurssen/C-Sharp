int[] numArray;
numArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

string[] peopleArray;
peopleArray = new string[4] { "Tim", "Martin", "Nikki", "Sara" };

bool[] truthyFalsey;
truthyFalsey = new bool[10] { true, false, true, false, true, false, true, false, true, false };


// ================================= //

List<string> flavors = new List<string>();
flavors.Add("Oreo");
flavors.Add("Chocolate Chip");
flavors.Add("Pistachio");
flavors.Add("Watermelon Sherbert");
flavors.Add("Vanilla");
Console.WriteLine(flavors[2]);
flavors.Remove("Chocolate Chip");
Console.WriteLine("There are {0} flavors that we carry.", flavors.Count);

// ================================= //

Dictionary<string, string> flavor = new Dictionary<string, string>();
flavor.Add("Kevin", "Oreo");
flavor.Add("Kyle", "Chocolate Chip");
flavor.Add("Debra", "Pistachio");
flavor.Add("John", "Watermelon Sherbert");
flavor.Add("Patrick", "Vanilla");
foreach (KeyValuePair<string, string> entry in flavor)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}