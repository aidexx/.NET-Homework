using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Decorator
{
    public class MagicianDecorator:PerformerDecorator
    {
        public MagicianDecorator(IPerformer component) : base(component){}

        public override void Perform()
        {
            base.Perform();
            Console.WriteLine("And i can perform magic tricks!");
        }
    }
}
