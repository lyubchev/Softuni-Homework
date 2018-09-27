using System;
using System.Globalization;


   public  class Program
    {
       public  static void Main(string[] args)
        {
             string format = "dd-MM-yyyy";
        DateTime input =DateTime.ParseExact(Console.ReadLine(),format,CultureInfo.InvariantCulture);
        DayOfWeek day = input.DayOfWeek;
        
		   
        if (day == DayOfWeek.Friday || day == DayOfWeek.Saturday)
        {
          Console.WriteLine("Party night! Today is: {0}", day);
          return;
        }
            Console.WriteLine("No party tonight! Today is: {0}", day);
	   }
    }