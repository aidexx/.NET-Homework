using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Homework_3.Decorator;
using SolidCorrectClass;
using SolidIncorrectClass;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new SolidIncorrectClass.Child() {Value1 = 1, Value2 = 2};


            //Декоратор

            var list = new List<IPerformer>
            {
                new MagicianDecorator(new Performer("Vasya")),
                new DancerDecorator(new MagicianDecorator(new Performer("Dima")))
            };

            foreach (var i in list)
            {
                i.Perform();
                Console.WriteLine(new string('_', 50));
            }
        }
    }
}
