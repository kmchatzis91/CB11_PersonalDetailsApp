﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDetailsApp
{
	class mainApp
	{
		public mainApp() 
		{

		} // 1st constructor end //

		public void startApp() 
		{
			// all the variables, lists and objs //
			string appName = "PersonalDetailsApp";
			string userChoice = string.Empty;
			List<Children> ChildrenList = new List<Children>();
			Person onlyPerson = new Person();

			IntroMethod(appName); // Initial details //

			while (userChoice != "0") // Project start //
			{
				Console.WriteLine("\n Ok now! Give any imput if you wish to continue or select '0' to Exit (and press 'Enter')! ");
				userChoice = Console.ReadLine();
				Console.Clear();

				if (userChoice == "0")
				{
					ExitMethod();
				}

				onlyPerson.setPerson();

				if (onlyPerson.hasChild == true)
				{
					createChildrenList(ChildrenList);
				}

				Console.WriteLine("\n Here is your details: \n");

				if (onlyPerson.isMarried == false && onlyPerson.hasChild == false)
				{
					Outcome1(onlyPerson);
				}
				else if (onlyPerson.isMarried == true && onlyPerson.hasChild == false)
				{
					Outcome2(onlyPerson);
				}
				else if (onlyPerson.isMarried == true && onlyPerson.hasChild == true)
				{
					Outcome3(onlyPerson, ChildrenList);
				}
				else
				{
					Outcome4(onlyPerson, ChildrenList);
				}

				Console.WriteLine("\n Press any key to continue... ");
				Console.ReadKey();
				Console.Clear();

			} // while (userChoice != "0") //

		} // public void startApp() end //

		public void IntroMethod(string appName)
		{
			Console.WriteLine("\n Hello and welcome to {0}! \n", appName);
			Console.WriteLine(" Here you can create a form with your Personal Details! Press any key to continue... ");
			Console.ReadKey();
			Console.Clear();

		} // public void IntroMethod() end //

		public void ExitMethod()
		{
			Console.WriteLine(" Thank you and goodbye :( Press any key to exit... ");
			Console.ReadKey();
			Environment.Exit(0);

		} // public void ExitMethod() end //

		public void createChildrenList(List<Children> ChildrenList) 
		{
			do
			{
				Children child = new Children();
				child.setChildren();
				ChildrenList.Add(child);
				Console.Clear();
				Console.WriteLine("\n If you have more than one child press any key to add them, else select '0' to continue! ");
			} while (Console.ReadLine() != "0");

		} // public void createChildrenList(List<Children> ChildrenList) end //

		public void Outcome4(Person onlyPerson, List<Children> ChildrenList) // not married with children //
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(" Personal Details Form of: {0} \n ", onlyPerson.userName);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" Birth Year: {0}, so you are {1} years old! ", onlyPerson.birthYear, onlyPerson.userAge);
			Console.WriteLine(" City of Birth: {0} and currently living in {1} ", onlyPerson.userCity, onlyPerson.currentCity);
			Console.WriteLine(" Favourite color: {0} ", onlyPerson.userColor);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" Marital status: Not married ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\n Number of children: {0} ", ChildrenList.Count);
			Console.ForegroundColor = ConsoleColor.White;
			foreach (var child in ChildrenList)
			{
				Console.WriteLine(" Child's name: {0}, Age: {1}, Year Born: {2} ", child.childName, child.childAge, child.childBornYear);
			}

		} // public void Outcome4(Person onlyPerson, Children child, List<Children> ChildrenList) end //

		public void Outcome3(Person onlyPerson, List<Children> ChildrenList) // married with children //
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(" Personal Details Form of: {0} \n ", onlyPerson.userName);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" Birth Year: {0}, so you are {1} years old! ", onlyPerson.birthYear, onlyPerson.userAge);
			Console.WriteLine(" City of Birth: {0} and currently living in {1} ", onlyPerson.userCity, onlyPerson.currentCity);
			Console.WriteLine(" Favourite color: {0} ", onlyPerson.userColor);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(" Marital status: Married for {0} years, since {1} ", onlyPerson.yearsMarried, onlyPerson.marriedYear);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\n Number of children: {0} ", ChildrenList.Count);
			Console.ForegroundColor = ConsoleColor.White;
			foreach (var child in ChildrenList)
			{
				Console.WriteLine(" Child's name: {0}, Age: {1}, Year Born: {2} ", child.childName, child.childAge, child.childBornYear);
			}

		} // public void Outcome3(Person onlyPerson, Children child, List<Children> ChildrenList) end //

		public void Outcome2(Person onlyPerson) // married no children //
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(" Personal Details Form of: {0} \n ", onlyPerson.userName);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" Birth Year: {0}, so you are {1} years old! ", onlyPerson.birthYear, onlyPerson.userAge);
			Console.WriteLine(" City of Birth: {0} and currently living in {1} ", onlyPerson.userCity, onlyPerson.currentCity);
			Console.WriteLine(" Favourite color: {0} ", onlyPerson.userColor);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(" Marital status: Married for {0} years, since {1} ", onlyPerson.yearsMarried, onlyPerson.marriedYear);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\n Children: Non existing or not recorded ");
			Console.ForegroundColor = ConsoleColor.White;

		} // public void Outcome2(Person onlyPerson) end //

		public void Outcome1(Person onlyPerson) // not married no children //
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(" Personal Details Form of: {0} \n ", onlyPerson.userName);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(" Birth Year: {0}, so you are {1} years old! ", onlyPerson.birthYear, onlyPerson.userAge);
			Console.WriteLine(" City of Birth: {0} and currently living in {1} ", onlyPerson.userCity, onlyPerson.currentCity);
			Console.WriteLine(" Favourite color: {0} ", onlyPerson.userColor);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" Marital status: Not married ");
			Console.WriteLine("\n Children: Non existing or not recorded ");
			Console.ForegroundColor = ConsoleColor.White;

		} // public void Outcome1(Person onlyPerson) end //

	} // class mainApp end //

} // namespace end //
