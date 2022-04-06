// Practive with DataStructures
Console.WriteLine("Working With Queues");

Queue<string> names = new Queue<string>();

names.Enqueue("Diego");
names.Enqueue("Phirith");
names.Enqueue("Donald");
names.Enqueue("Amin");
names.Enqueue("Rudy");

foreach(string name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine("After Dequeue:__________________");
names.Dequeue();

foreach(string name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("Using the Peek method: " + names.Peek());

if(names.Contains("Donald"))
{
    Console.WriteLine("Donald is in queue");
}

Console.WriteLine("\n");
string[] NamesArray = names.ToArray();
foreach(string name in NamesArray)
{
    Console.WriteLine(name);
}

//Dictionaries/////////////////////////////////////////////

Dictionary<string, string> myDict = new Dictionary<string, string> {{"one","first"}, {"two","second"}};
foreach(string key in myDict)
{
    Console.WriteLine(key);
}

