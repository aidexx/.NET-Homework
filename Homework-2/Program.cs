using System;
using System.IO;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(TestClass.GetDepositInterest(-5));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
