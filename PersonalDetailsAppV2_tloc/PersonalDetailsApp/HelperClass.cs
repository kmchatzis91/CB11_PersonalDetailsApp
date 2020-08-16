using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDetailsApp
{
	class HelperClass
	{
		public int ValidInt() 
		{
			int ValidInt = 0;
			bool IsValid = false;
			while (!IsValid)
			{
				IsValid = Int32.TryParse(Console.ReadLine(), out ValidInt);
				if (!IsValid)
				{
					Console.WriteLine(" The number you gave was not valid!!! ");
					Console.WriteLine(" Please give a valid value (integer) ");

					if (IsValid && ValidInt < 0)
					{
						ValidInt = 0;
					}
					else if (IsValid && ValidInt > 3000)
					{
						ValidInt = 3000;
					}
				}
				else
				{
					if (ValidInt < 0)
					{
						ValidInt = 0;
					}
					else if (ValidInt > 3000)
					{
						ValidInt = 3000;
					}
				}
			}

			return ValidInt;

		} // public int ValidInt() end //

		public bool ValidBool() 
		{
			string userChoice = string.Empty;
			bool ValidAnswer = false;
			bool userAnswer = false;
			yesORno();
			
			while (!ValidAnswer)
			{
				userChoice = Console.ReadLine();

				if ((userChoice == "y") || (userChoice == "Y"))
				{
					ValidAnswer = true;
					userAnswer = true;
				}
				else if ((userChoice == "n") || (userChoice == "N"))
				{
					ValidAnswer = true;
					userAnswer = false;
				}
				else
				{
					Console.WriteLine(" Wrong input! ");
					yesORno();
					ValidAnswer = false;
				}
			} // while (!ValidAnswer) end //

			return userAnswer;

		} // public bool ValidBool() //

		public void yesORno() 
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(" Write 'y' or 'Y' for YES... ");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" Write 'n' or 'N' for NO... ");
			Console.ForegroundColor = ConsoleColor.White;

		} // public void yesORno() end //

	} // class HelperClass end //

} // namespace end //