﻿using System;
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

        public void TestHaystack4()
        {

            Tester.AreEqual(
                Implementation.FindSequence(
                     new string[] { "apple", "banana", "pear" },
                     new string[] { "apple", "pear" }),
                -1);
        }

        public void TestHaystack5()
        {

            Tester.AreEqual(
                Implementation.FindSequence(
                    new string[] { "apple", "banana", "pear" },
                    new string[] { "apple" }),
                0);
        }

        public void TestHaystack6()
        {

            Tester.AreEqual(
                Implementation.FindSequence(
                    new string[] { "eleven", "twelve", "thirteen", "thirteen", "fourteen", "fifteen", "sixteen" },
                    new string[] { "thirteen", "fourteen", "fifteen" }),
                3);
        }

        public void TestHaystack7()
        {

            Tester.AreEqual(
                Implementation.FindSequence(
                    new string[] { },
                    new string[] { }),
                -1);
        }

        public void TestHaystack8()
        {

            Tester.AreEqual(
                Implementation.FindSequence(
                    new string[] { "apple", "banana", "pear" },
                    new string[] { }),
                -1);
        }

        public void TestHaystack9()
        {

            Tester.AreEqual(
                Implementation.FindSequence(
                   new string[] { },
                   new string[] { "apple", "banana", "pear" }),
                -1);
        }

        public void TestHaystack10()
        {

            Tester.AreEqual(
                Implementation.FindSequence(
                  new string[] { "eleven", "twelve", "thirteen", "thirteen", "fourteen", "thirteen", "fourteen", "fifteen", "fifteen", "sixteen" },
                  new string[] { "thirteen", "fourteen", "fifteen" }),
                5);
        }

        public void TestHaystack11()
        {

            Tester.AreEqual(
                Implementation.FindSequence(
                   new string[] { "eleven", "twelve", "thirteen", "thirteen", "fourteen", "fifteen", "thirteen", "fourteen", "fifteen", "sixteen" },
                   new string[] { "thirteen", "fourteen", "fifteen" }),
                3);
        }

        public void TestHaystack12()
        {

            Tester.AreEqual(
                Implementation.FindSequence(
                   new string[] { "thirteen", "fourteen", "fifteen" },
                   new string[] { "eleven", "twelve", "thirteen", "thirteen", "fourteen", "thirteen", "fourteen", "fifteen", "fifteen", "sixteen" }),
                -1);
        }

        public void TestHaystack13()
        {

            Tester.AreEqual(
                Implementation.FindSequence(
                   new string[] { "eleven", "twelve", "thirteen", "thirteen", "fourteen", "sixteen", "thirteen", "fourteen", "fifteen" },
                   new string[] { "thirteen", "fourteen", "fifteen" }),
                6);
        }
    }
}
