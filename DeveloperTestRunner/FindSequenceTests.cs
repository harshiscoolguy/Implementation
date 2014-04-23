using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeveloperTest;

namespace DeveloperTestRunner
{
    class FindSequenceTests : Tests
    {
        public void TestHaystack1()
        {
            Tester.AreEqual(
                Implementation.FindSequence(
                    new string[] { "apple", "banana", "pear" },
                    new string[] { "banana", "pear" }),
                1);
        }

        public void TestHaystack2()
        {

            Tester.AreEqual(
                Implementation.FindSequence(
                    new string[] { "apple", "banana", "pear" },
                    new string[] { "four", "five" }),
                -1);
        }

        public void TestHaystack3()
        {

            Tester.AreEqual(
                Implementation.FindSequence(
                    new string[] { "apple", "banana", "pear" },
                    new string[] { "pear", "four" }),
                -1);
        }
    }
}
