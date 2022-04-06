namespace GuessingGame
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Guessing Game!");
			
					
			while(true)
			{
				/*
				string? one;
				string? two;

				one = Console.ReadLine();
				two = Console.ReadLine();

				Console.WriteLine(one);
				Console.WriteLine(two);
				*/
				Console.WriteLine("Enter a number");
				Console.WriteLine("[0] - Exit Game");
				Console.WriteLine("[1] - Guessing Game!");
				Console.WriteLine("[2] - Math Challenge!");
				int menu =int.Parse(Console.ReadLine());
				
				switch (menu)
				{
					case 0:
						Console.WriteLine("Press Enter to Continue");
						Console.ReadLine();
						Console.Clear();
						return;
					case 1:
						GuessingGame();
						break;
					
					case 2:
						AdditionChallenge();
						break;
					default:
						Console.WriteLine("Unregistered input! Please enter either 1 or 0");
						break;
				}


			}
		}

		static void GuessingGame()
		{
			var rand = new Random(); //This creates a random numbers 
			int secret = rand.Next(11);//Limits random number from 0-10 and saves it to secret
					

			while(true)//Begins loop with infinte amount of tries until player guesses correctly
					{
				Console.WriteLine("Guess a number between 0 and 10: ");//Prompt User
				int? input;
				try
				{
					input = int.Parse(Console.ReadLine());//Read user input and save it to variable
				}
				catch(System.Exception ex)
				{
					Console.WriteLine(ex.Message);
					//Console.WriteLine("Invalid input detected. Returning to menu.");
					break;
				}
				Console.WriteLine("You guessed: " + input);//Confirming user input


				if(input == secret)
				{
					Console.WriteLine("YOU GOT IT!!");
					Console.WriteLine("Press Enter to Continue");
					Console.ReadLine();
					Console.Clear();
					break;//Break out of loop if guessed correctly
				}
				else if(input > secret)
				{
					Console.WriteLine("uh oh, you've guessed to high!");
					Console.WriteLine("Press Enter to Continue");
					Console.ReadLine();
					Console.Clear();
				}
				else
				{
					Console.WriteLine("Mhh, looks like you've guessed too low!");
					Console.WriteLine("Press Enter to Continue");
					Console.ReadLine();
					Console.Clear();
				}
			}
			Console.WriteLine("Thanks for playing!");
			Console.WriteLine("Press Enter to Continue");
			Console.ReadLine();
			Console.Clear();
		}

		static void AdditionChallenge()
		{
			var rand = new Random(); //This creates a random numbers 
			int num1 = rand.Next(101), num2 = rand.Next(101);
						int solution = num1 + num2;
						
						Console.WriteLine("Welcome to the addition challenge!");
						while(true)
						{
							Console.WriteLine("Your challenge is: ");
							Console.WriteLine(num1+" + "+num2+" = ?");
							string input = Console.ReadLine();

							int intput;

							bool success = int.TryParse(input, out intput);
							if(success)
							{
								intput = int.Parse(input);
							}
							else
							{
								Console.WriteLine("Invalid Input. Exiting Addition Challenge.");
								break;
							}

							if(intput == solution)
							{
								Console.WriteLine("You are CORRECT!");

								break;
							}
							else
							{
								Console.WriteLine("Incorrect! Off by: " + Math.Abs(solution - intput));
							}
						}
						Console.WriteLine("Press Enter to Continue");
						Console.ReadLine();
						Console.Clear();
		}
	}
}