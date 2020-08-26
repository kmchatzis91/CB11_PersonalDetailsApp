using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDetailsApp
{
	class Children : HelperClass
	{
		public string childName { get; private set; }
		public int childBornYear { get; private set; }
		public int childAge { get; private set; }
		private int CurrentYear = Convert.ToInt32(DateTime.Now.Year);

		public Children()
		{

		} // 1st constructor end //

		private Children(string childname, int childbornyear) 
		{
			childName = childname;
			childBornYear = childbornyear;
			childAge = CurrentYear - childbornyear;

		} // 2nd constructor end //

		public void setChildren() 
		{
			Console.WriteLine("\n What is the name of your child? ");
			childName = Console.ReadLine();
			Console.WriteLine("\n Which year was your child born (ex. 2000)? ");
			childBornYear = ValidInt();
			childAge = CurrentYear - childBornYear;
			Console.Clear();

		} // public void setChildren() //

	} // class Children end //

} // namespace end //
