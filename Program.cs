//using directive
using System;

namespace Treehouse.FitnessFrog
{
  class Program
  {
      static void Main()
      {
          var runningTotal = 0.0;

          while (true)
          {
              // Prompt the user for minutes exercised
              Console.Write("Enter how many minutes you exercised or type 'quit' : ");

              var entry = Console.ReadLine();
              double minutes;

              if (entry.ToLower() == "quit")
              {
                 break;
              }
              try
              {
                minutes = double.Parse(entry);
              }
              catch(FormatException)
              {
                Console.WriteLine("This is not valid input.");
                continue;
              }

              if(minutes <= 0)
              {
                Console.WriteLine(minutes + " is not an acceptable value.");
                continue;
              }
              else if (minutes <= 10)
              {
                Console.WriteLine("Better than nothing, am I right?");
              }
              else if(minutes <= 30)
              {
                Console.WriteLine("Way to go hot stuff!");
              }
              else if(minutes <= 60)
              {
                Console.WriteLine("You must be a ninja warrior in training!");
              }
              else
              {
                Console.WriteLine("Now you are just showing off!");
              }
              runningTotal += minutes;
              // Add minutes exercised to total
              // Display total minutes exercised to the screen
              Console.WriteLine("You've exercised " + runningTotal + " minutes");
              // Repeat until the user quits
          }
          Console.WriteLine("Goodbye");
      }
  }
}
