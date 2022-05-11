using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericio18_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of the matriz :");
            int n = int.Parse(Console.ReadLine());
            double[,] mat = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int matNum = int.Parse(Console.ReadLine());
                    mat[i, j] = matNum;
                }
            }
            Console.WriteLine("Main diagonal:");
            for(int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + ", ");
            }

            Console.WriteLine();

            int count = 0;
            Console.WriteLine("Negative numbers: ");
            foreach(int obj in mat)
            {
                if(obj < 0)
                {
                    Console.Write(obj + ", ");
                    count++;
                }
            }
            Console.WriteLine("\nTotal of negative numbers: " + count);
        }
    }
}
