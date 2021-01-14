using System; 

class Menu
{
	private int _menuOption;

	public void DisplayMenu()
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("**** FLIGHT PLANNING ****");
		Console.WriteLine();
		Console.WriteLine("** MAIN MENU **");
		Console.WriteLine();
		Console.ForegroundColor = ConsoleColor.White;

		Console.WriteLine("1 Enter airport details");
		Console.WriteLine("2 Enter flight details");
		Console.WriteLine("3 Enter price plan and calculate profit");
		Console.WriteLine("4 Clear data");
		Console.WriteLine("5 Quit");
		GetMenuOption();
	}

	private void GetMenuOption()
	{
		bool validOption = false;
		while (validOption == false)
		{
			_menuOption = ValidateMenuOption();
			validOption = true;
			Console.WriteLine("Menu option inputted.");
		}

	}

	private int ValidateMenuOption()
	{
		int validatedOption = 0;
		bool validated = false;
		while (validated == false)
		{
			try
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine();
				Console.Write("Menu option: ");
				Console.ForegroundColor = ConsoleColor.Blue;
				validatedOption = int.Parse(Console.ReadLine());
				if (validatedOption < 1 || validatedOption > 5)
				{
					validated = false;
					throw new Exception();
				}
				else
				{
					validated = true;
				}
			}
			catch
			{
				Console.WriteLine("Please enter a valid option.");
				Console.WriteLine("Enter 1, 2, 3, 4, or 5.");
			}
		}
		
		Console.ForegroundColor = ConsoleColor.White;
		return validatedOption;
	}
}