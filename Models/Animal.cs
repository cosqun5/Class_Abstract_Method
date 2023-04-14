using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract__Class_Abstract_Method.Models
{
     abstract class Animal
    {
        public abstract void Eat();
        public virtual void See()
        {
            Console.WriteLine("See as Animal");
        }
    }
}
