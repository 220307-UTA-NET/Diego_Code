
//string variable = " ";

//variable = Console.ReadLine();
//Console.WriteLine(variable);

int number = 5;//only whole numbers expected in int variables
float fnumber = 5.555566F; //float is short for floating-point value
double dnumber = 5.56957;

Console.WriteLine("This is an int: " + number);
Console.WriteLine("This is a float: " + fnumber);
Console.WriteLine("This is a double: " + dnumber);

int x, y, z;
x = 2;
y = 3;
z = x + y;

Console.WriteLine("z = " + z);

if (z > y)
{
	Console.WriteLine("z is greater than y");
}
else if(z < y)
{
	Console.WriteLine("z is less than y");
}
else
{Console.WriteLine("z is equal to y");}
