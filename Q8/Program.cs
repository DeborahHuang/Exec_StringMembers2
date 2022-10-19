using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q8隱藏手機的資訊
			//呈現 0935****46
			string number = "0935123446";
			string sid = $"{number.Substring(0,4)}"+$"{new string('*',4)}"+$"{number.Substring(7,3)}";
			Console.WriteLine(sid);
		}
	}
}
