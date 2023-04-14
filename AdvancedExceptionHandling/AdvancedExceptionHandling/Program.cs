using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExceptionHandling
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string ageText = "";
            int ageNumber = 0;
            try
            {
                ExceptionDemo();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Custom Implementaion Exception");
                Console.WriteLine(ex.Message);
            }
            try
            {


                Console.Write("Enter your age: ");
                ageText = Console.ReadLine();
                ageNumber = ConvertToNumber(ageText);
            
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) when (ex.InnerException.InnerException.Message.ToLower() == "test" )
            {
                Console.WriteLine("When inner exception is null");
                Console.WriteLine(ex.Message);
            }
            catch 
            {
                Console.WriteLine("Default exception");
            }
            finally { 

                Console.WriteLine($"Age is {ageNumber}"); 
            }
            Console.ReadLine();
        }

        private static void ExceptionDemo()
        {
            throw new NotImplementedException("You forgot to implement this method");
        }

        private static int ConvertToNumber(string ageText)
        {
            bool isValidAge = int.TryParse(ageText, out int age);
            if (isValidAge == false)
            {
                throw new InvalidCastException("Could not covert the age to number");
            }
            else if (age < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid age", new ArgumentOutOfRangeException("Negative", new ArgumentException("Test")));
            }
            else
            {
                return age;
            }
        }
    }
}
