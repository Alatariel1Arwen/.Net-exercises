using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public virtual void Speak() 
        {
            Console.WriteLine("Generic animal sound.");
        }
    }
}
