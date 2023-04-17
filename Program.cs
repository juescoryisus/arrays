
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr =new int[3, 3];

            arr[0, 1]= 10;
            arr[1, 2]= 20;
            arr[2, 0]= 30;

            for (int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
