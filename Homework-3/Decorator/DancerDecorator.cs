using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Decorator
{
    public class DancerDecorator:PerformerDecorator
    {
        public DancerDecorator(IPerformer component):base(component){}
        public override void Perform() 
        {
            base.Perform();
            Console.WriteLine("And i can dance!");
        }
    }
}
