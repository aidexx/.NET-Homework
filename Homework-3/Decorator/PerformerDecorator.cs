using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Decorator
{
    public class PerformerDecorator : IPerformer
    {
        protected IPerformer Performer;

        public PerformerDecorator(IPerformer component)
        {
            Performer = component;
        }
        public virtual void Perform()
        {
            Performer.Perform();
        }

    }
}
