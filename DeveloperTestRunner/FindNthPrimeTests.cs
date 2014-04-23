using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeveloperTestRunner
{
    internal class FindNthPrimeTests : Tests
    {
        public void FindNthPrimeTest1()
        {
            Tester.AreEqual(Implementation.FindNthPrimeNumber(5), 11);
        }

        public void FindNthPrimeTest2()
        {
            Tester.AreEqual(Implementation.FindNthPrimeNumber(10), 29);
        }

        public void FindNthPrimeTest3()
        {
            Tester.AreEqual(Implementation.FindNthPrimeNumber(1), 2);
        }
        public void FindNthPrimeTest4()
        {
            Tester.AreEqual(Implementation.FindNthPrimeNumber(2), 3);
        }
        public void FindNthPrimeTest5()
        {
            Tester.AreEqual(Implementation.FindNthPrimeNumber(3), 5);
        }
        public void FindNthPrimeTest6()
        {
            Tester.AreEqual(Implementation.FindNthPrimeNumber(0), -1);
        }
        public void FindNthPrimeTest7()
        {
            Tester.AreEqual(Implementation.FindNthPrimeNumber(-50), -1);
        }
        public void FindNthPrimeTest8()
        {
            Tester.AreEqual(Implementation.FindNthPrimeNumber(100), 541);
        }
        public void FindNthPrimeTest9()
        {
            Tester.AreEqual(Implementation.FindNthPrimeNumber(100000), 1299709);
        }
    }
}
