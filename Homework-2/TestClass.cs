using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Homework_2
{
    class TestClass
    {

        /// <summary>
        /// Calculates the interest of a bank deposit,
        /// considering that it increases periodically.
        /// </summary>
        /// <param name="depositTerm"></param>
        /// <returns>Returns the interest of a given deposit (in percents),
        /// depending on the length of deposit term.</returns>
        public static decimal GetDepositInterest(int depositTerm)
        {
            if (depositTerm < 0) throw new ArgumentOutOfRangeException($"Term length must be a positive value : {depositTerm}");

            if (depositTerm <= 2)
            {
                return 10;
            }else if (depositTerm <= 5)
            {
                return 13.6M;
            }else if (depositTerm <= 8)
            {
                return 16.5M;
            }
            else
            {
                return 20;
            }
        }
    }
}
