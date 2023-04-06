using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 5];
            string[,] strArr = new string[3, 4];
            for (int i = 0; i < 4; i++)
            {
                arr[i, 0] = 2;
            }
            Console.WriteLine(arr[3, 0]);
            Console.ReadLine();
        }
    }
}
