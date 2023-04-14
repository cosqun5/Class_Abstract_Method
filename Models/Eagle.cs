using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract__Class_Abstract_Method.Models
{
    internal class Eagle : Bird
    {
        public Eagle() { }

        public override void Fly()
        {
            Console.WriteLine("Eagle as Fly");
        }
        public override void Eat()
        {
            Console.WriteLine("Eagle as Eat");
        }
        public override void See()
        {
            Console.WriteLine("See as Eagle");
        }
    }
}
