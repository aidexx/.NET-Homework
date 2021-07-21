using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Decorator
{
    public  interface IPerformer
    {
        public void Perform();
    }

    public class Performer : IPerformer
    {
        public readonly string Name;

        public Performer(string name)
        {
            Name = name;
        }
        public void Perform()
        {
            Console.WriteLine($"My name is {Name}! I can sing!");
        }
    }
}
