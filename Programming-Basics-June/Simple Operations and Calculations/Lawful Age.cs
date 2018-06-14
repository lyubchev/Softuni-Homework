using System;
using System.Globalization;


   public  class Program
    {
       public  static void Main(string[] args)
        {
            string pattern = "d-M-yyyy";
		   	string tostringpattern="dd-MM-yyyy";
			DateTime birth =DateTime.ParseExact(Console.ReadLine(),pattern,CultureInfo.InvariantCulture);		   	
			birth=birth.AddYears(18);
			Console.WriteLine(birth.ToString(tostringpattern));
        }
    }