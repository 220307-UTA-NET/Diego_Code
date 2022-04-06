namespace FunctionTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starting: ");

            NewFunction();

            PrintValue(6);
            string returned;
            returned = GetString();
            Console.WriteLine(returned);
        }
        static string GetString()
        {
            string x = "Hello string!";
            return x;
        }

        static void NewFunction()
        {
            Console.WriteLine("Running NewFunction()!");
        }

        static void PrintValue(int num)
        {
            Console.WriteLine("Printing: " + num);
        }
    }
}