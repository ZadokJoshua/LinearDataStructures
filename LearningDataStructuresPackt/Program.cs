using LearningDataStructuresPackt1;

Rectangle a = new Rectangle(1, 2);
Rectangle b = new Rectangle(3, 5);

Console.WriteLine($"Rectangle a area: {a.GetArea()}");
Console.WriteLine($"Rectangle b area: {b.GetArea()}");
Console.WriteLine($"No. of angles in a rectangle is {Rectangle.GetNumberOfAngles()}");

Pair<int> pair = new Pair<int>(2, 6);
Pair<string> pair1 = new Pair<string>("Zadok", "Joshua");
Console.WriteLine($"First Pair: {pair.ReadPair}");

Console.ReadLine();
