using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDetailsApp
{
	class Person : HelperClass
	{
		public string userName { get; private set; }
		public int birthYear { get; private set; }
		public int userAge { get; private set; }
		public string userCity { get; private set; }
		public string currentCity { get; private set; }
		public string userColor { get; private set; }
		public bool isMarried { get; private set; }
		public int marriedYear { get; private set; }
		public int yearsMarried { get; private set; }
		public bool hasChild { get; private set; }

		protected int CurrentYear = Convert.ToInt32(DateTime.Now.Year);

		public Person()
		{

		} // 1st constructor end //

		private Person(string username, int birthyear, string usercity, string currentcity, string usercolor, bool ismarried, bool haschild)
		{
			userName = username;
			birthYear = birthyear;
			userAge = CurrentYear - birthyear;
			userCity = usercity;
			currentCity = currentcity;
			userColor = usercolor;
			isMarried = ismarried;
			yearsMarried = CurrentYear - marriedYear;
			hasChild = haschild;

		} // 2nd constructor end //

		public void setPerson() 
		{
			Console.WriteLine("\n What's your name? ");
			userName = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("\n Which year were you born (ex. 1991)? ");
			birthYear = ValidInt();
			userAge = CurrentYear - birthYear;
			Console.Clear();
			Console.WriteLine("\n In which city were you born (ex. Athens)? ");
			userCity = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("\n Where do you live now (ex. Thessaloniki)? ");
			currentCity = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("\n What's your favorite color (ex. Blue)? ");
			userColor = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("\n Are you married? ");
			isMarried = ValidBool();
			Console.Clear();
			if (isMarried == true) 
			{
				Console.WriteLine("\n Which year were you married (ex. 2005)? ");
				marriedYear = ValidInt();
				yearsMarried = CurrentYear - marriedYear;
				Console.Clear();
			}
			Console.WriteLine("\n Do you have any children? ");
			hasChild = ValidBool();
			
		} // public void setPerson() end //
	
	} // class Person end //

} // namespace end //
