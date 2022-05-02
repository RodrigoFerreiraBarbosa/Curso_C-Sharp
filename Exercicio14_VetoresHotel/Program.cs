using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14_VetoresHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented ?: ");
            int cadNum = int.Parse(Console.ReadLine());

            RentCad[] vect = new RentCad[10];
            for (int i = 0; i < cadNum; i++)
            {
                Console.WriteLine("Rent #" + (i+1) +":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room :");
                int rent = int.Parse(Console.ReadLine());
                Console.WriteLine();
                vect[rent] = new RentCad { Name = name, Email = email, Rent = rent};
            }
            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < vect.Length; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(vect[i].ToString());
                }
            }
            
        }
    }
}
