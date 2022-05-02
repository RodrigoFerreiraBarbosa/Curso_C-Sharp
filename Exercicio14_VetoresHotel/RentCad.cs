using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14_VetoresHotel
{
    internal class RentCad
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Rent { get; set; }

        public override string ToString()
        {
            return Rent + ": " + Name +", " + Email ;
        }
    }
}
