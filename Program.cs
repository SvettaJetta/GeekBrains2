using System;
using System.IO;

namespace Example
{
    class Program
    { 
        public static String task10(int number)
        {
            String result;
            String str = Convert.ToString(number);
            result  = Convert.ToString(str[1]);
            
            return result;
        }
        
        public static String task13(int number)
        {
            String result;
            String str = Convert.ToString(number);
            try
            {
                result  = Convert.ToString(str[2]);

            }catch{

                result = "no char";

            }
            return result;     
           
        }

        public static String task15(int number)
        {
            String result = "not a day";
            if (number > 0 && number < 8)
            {
                if(number > 5)
                {
                    result = "yes";
                }
                else
                {
                    result = "no";
                }

            }     
            return result;
        }

        public static String task_added(int number)
        {
            String result = "no";
            if ((number % 7 == 0) && (number % 23 == 0))
            {
                result = "yes";
            }

            return result;
            
        }



        static void Main(string[] args)
        {  
            Console.WriteLine("task");
            Console.WriteLine("Enter number for task 10 and 13 ");
            int n = int.Parse((Console.ReadLine()));           
            Console.WriteLine(task10(n));
            Console.WriteLine(task13(n));

            Console.WriteLine("task");
            Console.WriteLine("is a day?");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine(task15(day));

            Console.WriteLine("task _ added");
            Console.WriteLine("multiple of 7 and 23");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(task15(num));

                        
            
        }
    }
}
