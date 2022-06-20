using System;

namespace AssessmentSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[12] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

          Console.WriteLine($"Number of months is: {months.Length}");
          Console.WriteLine();

          Console.WriteLine("Rank of month returned:");
          for(int index = 0; index < months.Length; index++)
            {
                Console.WriteLine("{0} {1}", index, months[index]);
            }
          Console.WriteLine();

          Console.WriteLine("Order of months reversed:");
          for(int index = months.Length -1; index >= 0; index--)
            {

                Console.WriteLine(months[index]);
            }
          Console.WriteLine();

          Console.WriteLine("Months cloned using array method:");
          String[] monthClone = months.Clone() as string[];
          Console.WriteLine(string.Join(",", months));
          Console.WriteLine(string.Join(",", monthClone));
          Console.WriteLine();

          string[] monthTarget = new string [6];
          Array.Copy(months, monthTarget, 6);
          Console.WriteLine("Copied Months:");
          foreach(string month in monthTarget)
            {
                Console.WriteLine(month);
            }
          Console.WriteLine();
            
          Console.WriteLine("Months sorted alphabetically:");
          Array.Sort(months);
          foreach(string month in months)
            {
                Console.WriteLine(month);
            }
          Console.WriteLine();

          Console.WriteLine("All months cleared:");
          Array.Clear(months, 0, months.Length);
          Console.WriteLine("Array after using clear:");
          foreach(string month in months)
            {
                Console.WriteLine(month);
            }          
        }
    }
}
