using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDetailsApp
{
	class Person : HelperClass
	{
		public string userName { get; set; }
		public int birthYear { get; set; }
		public int userAge { get; set; }
		public string userCity { get; set; }
		public string currentCity { get; set; }
		public string userColor { get; set; }
		public bool isMarried { get; set; }
		public int marriedYear { get; set; }
		public int yearsMarried { get; set; }
		public bool hasChild { get; set; }

		public int CurrentYear = Convert.ToInt32(DateTime.Now.Year);

		public Person(string username, int birthyear, string usercity,string currentcity, string usercolor, bool ismarried, bool haschild)
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
		} // 1st constructor end //

		public Person()
		{
			
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
