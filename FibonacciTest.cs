using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class FibonacciTest
    {
        private int CaclFibonacciNumber(int position)
        {
            if (position == 0) return 0;
            if (position <= 2) return 1;
            var calc = CaclFibonacciNumber(position - 1) + CaclFibonacciNumber(position - 2);
            return calc;
        }

        [TestMethod]
        public void TestFibonacci()
        {
            int[,] intArray = { 
                                { 0, 0 }, 
                                { 1, 1 }, 
                                { 2, 1 },
                                { 3, 2 },
                                { 4, 3 },
                                { 5, 5},
                                { 6, 8 },
                                { 7, 13 },
                                { 8, 21 },
                                { 9, 34 },
                                { 10, 55 },
                                { 11, 89 },
                                { 12, 144 },
                                { 13, 233},
                                { 14, 377 },
                                { 15, 610 },
                              };

            
            for(int i = 0; i < intArray.GetLength(0); i++)
            {
                System.Diagnostics.Debug.WriteLine(i.ToString());
                Assert.AreEqual(intArray[i,1], CaclFibonacciNumber(intArray[i,0]));
            }
        }

    }
}
