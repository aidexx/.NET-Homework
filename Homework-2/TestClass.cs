using System;
using Microsoft.VisualBasic;

namespace Homework_2
{
    public class TestClass
    {

        /// <summary>
        /// Calculates the interest of a bank deposit,
        /// considering that it increases periodically.
        /// </summary>
        /// <param name="depositTerm"></param>
        /// <returns>The interest of a given deposit (in percents),
        /// depending on the length of deposit term.</returns>
        public static decimal GetDepositInterest(int depositTerm) => depositTerm switch
        {
            >= 0 and <= 2 => 10M,
            >= 3 and <= 5 => 13.6M,
            >= 6 and <= 8 => 16.5M,
            > 8 => 20M,
           _ => throw new ArgumentOutOfRangeException($"depositTerm term must be a positive number : {depositTerm}")
        };
    }
}
