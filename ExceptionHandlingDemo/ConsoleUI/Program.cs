using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            //CheckingStackTrace();
            try
            {
                BadCall();
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an exception thrwon in our app");
                Console.WriteLine(ex.Message);
                throw ex;
            }
            Console.ReadLine();
        }

        private static void CheckingStackTrace()
        {
            BadCall();
        }

            private static void BadCall()
        {
            int[] ages = new int[] { 1, 3, 5 };

            for (int i = 0; i <= ages.Length; i++)
            {
                try
                {
                    Console.WriteLine(ages[i]);
                }
                catch (Exception ex)
                {
                    // If you are writing to to console (Which means you are trying to show it in user interface) then catch
                    // it at the very very top (layers, maybe this part is inside 3 layers of classes) because the inner
                    // lasyer or libraries does not have access to the UI.
                    // So throw it from here and display it at the top

                 //   Console.WriteLine("We had an error");
                   // Console.WriteLine(ex); // This is for log file as this gives line number of where it occured
                   // Console.WriteLine(ex.Message); // This is for user
                    //throw;                          
                    throw new Exception("There was an error in our array", ex); // This will give the innerexception. Amd innerexception has the stacktrace also. So it will give the correct line number where error occured 
                }
            }
        }
    }
}
