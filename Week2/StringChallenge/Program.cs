string x;
int y;

Console.WriteLine("Pease enter your message and press enter");
x = Console.ReadLine();

Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");
y = int.Parse(Console.ReadLine());

char z;
Console.WriteLine("Which character should I search for in your original message");
z = char.Parse(Console.ReadLine());

Console.WriteLine("Please Enter First Name: ");
string FName = Console.ReadLine();

Console.WriteLine("Please Enter Last Name: ");
string LName = Console.ReadLine();

Console.WriteLine(FName + " " + LName);
Console.WriteLine("Initials: "+FName.Substring(0,1) + LName.Substring(0,1));
Console.WriteLine("Abrivation: "+FName + " " + LName.Substring(0,2));
Console.WriteLine("Length of last name: "LName.Length);