using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract__Class_Abstract_Method.Models
{
    class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine(" Fish as Shark ");
        }

        public override void Svim()
        {
            Console.WriteLine("Swim as Shark");
        }
    }
}
