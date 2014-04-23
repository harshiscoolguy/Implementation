using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeveloperTest.TreeClasses;

namespace DeveloperTest
{
    public class Implementation : IDeveloperTest
    {

        //public int FindNthPrimeNumber(int nthPrime)
        //{
        //    int num, count, i;
        //    num = 1;
        //    count = 0;

        //    if ((nthPrime <= 0) || (nthPrime.GetType() != typeof(int))) //Validating the input
        //            {
        //                Console.WriteLine("Illegal Parameters. Enter a non-negative integer greater than 0");
        //                return -1;
        //            }
        //    while (count < nthPrime)
        //    {
        //        num = num + 1; //find the next prime number 
        //        for (i = 2; i <= num; i++)
        //        {

        //            if (num % i == 0)
        //            {
        //                break; //Break if at any point its divisible. No need to check further.
        //            }
        //        }
        //        if (i == num)
        //        {
        //            count = count + 1; //Its a prime number and so increment the value.
        //        }
        //    }  //The condition terminates when the count is equal to the num, which means we found the nth Prime number.
        //    return num;
        //}


        /*
         * The following is another way to achieve the same solution. 
         * The following was the one that I originally wrote but then I tried to shorten it and the result was the above mentioned code.
         * However, by no means, the above code is optimized as it takes way longer for the larger inputs than the following one. In thise case, the following bigger code is more effecient for all kinds of input.
         * I just wanted to show two possible ways that I could find to solve the problem.
         */

        public int FindNthPrimeNumber(int nthPrime)
        {
            int counter = 2;
            if ((nthPrime <= 0) || (nthPrime.GetType() != typeof(int))) //Validating the input
            {
                Console.WriteLine("Illegal Parameters. Enter a non-negative integer greater than 0");
                return -1;
            }
            else if (nthPrime == 1)  //If value is 1
            {
                return 2;
            }
            else if (nthPrime == 2) //If value is 2
            {
                return 3;
            }
            else                   // For all other values
            {
                for (int i = 4; counter != nthPrime; i++)
                {
                    if (isPrime(i))  //Check if each number is prime
                    {
                        counter++;  //Increase the counter if its prime
                        if (counter == nthPrime)  //If counter matches the input, it means we have arrived at the desired Nth prime number
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;  //covering all paths and returning -1 in case.
            // throw new NotImplementedException();
        }

        public bool isPrime(int n)
        {
            if (n == 2) //Return true for 2 as its the first prime number
            {
                return true;
            }
            else //Check for all other cases
            {
                double root = Math.Sqrt(n);  //Following the approach: If the number is not divisible by any integer till its square root, its a prime number
                if (root < 4)                // Checking for individual divisibilty in case the square root is too small
                {
                    for (int i = 2; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            return false;   //Return false if at any point its divisible. No need to check further.
                        }
                    }
                }
                else                        //If the square root is greater than 4, only checking divisibilty only till the square root.
                {
                    for (int i = 2; i <= root; i++)
                    {
                        if (n % i == 0)
                        {
                            return false;  //Return false if at any point its divisible. No need to check further.
                        }
                    }
                }
            }
            return true;  //Covering all the paths in case
        }






        public bool OccursDuring(DateTime appointment1Start, DateTime appointment1End,
            DateTime appointment2Start, DateTime appointment2End)
        {
            if ((appointment2Start >= appointment1Start && appointment2Start < appointment1End) ||  //appointment2Start comes between appointment1Start and appointment1End
                (appointment2End <= appointment1End && appointment2End > appointment1Start) ||  //appointment1Start is between appointment2Start and appointment2End
                (appointment2Start <= appointment1Start && appointment2End >= appointment1End) ||  //appointment1Start and appoint1End is between appointment2Start and appointment2End, meaning entire appointment1 is within appointment2 timespan
                (appointment1Start <= appointment2Start && appointment1End >= appointment2End))     //Entire appointment2 is within appointment1 timespan
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();

            // Another way to achieve the same
            /*
            return (
                (appointment2Start >= appointment1Start && appointment2Start < appointment1End) || (appointment2End <= appointment1End && appointment2End > appointment1Start) || (appointment2Start <= appointment1Start && appointment2End >= appointment1End) || (appointment1Start <= appointment2Start && appointment1End >= appointment2End)
            );
            */

            //Yet another way
            /*
            return appointment1End > appointment2Start && appointment2End > appointment1Start; //simply comparing either of them starts before another ends.
             */
        }








        /*
         * The problem statement does not include the case in which needle appears twice in haystack. 
         * Since the signature of the statement only allows for one integer to be returned, I took the liberty of assuming that we will return the index of the first occurence in such cases.
         * I have added the test case for it as well.
         */
        public int FindSequence(string[] haystack, string[] needle)
        {
            int index = -1, haystackIndex = -1, needleIndex = 0, occurenceIndex = 0, tempIndex = -1;
            List<int> occurences = new List<int>();

            if (needle.Length <= 0 || haystack.Length <= 0)
            { //To check whether either of them are empty
                return index;
            }

            index = Array.FindIndex(haystack, x => x.Contains(needle[0])); //If the first element does not match, no need to check further
            if (index == -1)
            {
                return index;
            }

            do
            {															   //If the first element matches, check for how many times that value occurs in the haystack to check for all possible substrings starting from those places.	
                tempIndex = Array.IndexOf(haystack, needle[0], tempIndex + 1);
                occurences.Add(tempIndex);
            } while (-1 != tempIndex);

            haystackIndex = index;                          //Set the haystackIndex to the index of the first match.

            while (needleIndex < needle.Length)
            {
                if (haystackIndex < haystack.Length && haystack[haystackIndex] == needle[needleIndex])
                {                                                        //Need to check if the index is out of bounds for haystack because it will throw an error if haystack's last word will match with needle's first word
                    haystackIndex += 1;
                    needleIndex += 1;
                    continue;
                }
                else if (occurences.Count() > 2 && occurences[occurenceIndex] != -1)
                {                                    // If the first word is matched multiple times, then we need to check for substring matches for all those times. 
                    occurenceIndex += 1; 			//Occurences count is checked for size greater than 2 because -1 is always added at the end of the List when matching and so even if there is one match, the List will have two elements
                    haystackIndex = occurences[occurenceIndex];
                    needleIndex = 0;
                }
                else
                {
                    return -1;
                }

            }

            return occurences[occurenceIndex];
            //throw new NotImplementedException();
        }


        /*
         * To be honest, I have referenced Stackoverflow for the solution to this problem. 
         * http://stackoverflow.com/questions/19969858/building-a-tree-from-a-list-using-recursion
         * I will learn better on the tree implementation in the forthcoming days. 
         */
        public TreeNode BuildTree(IEnumerable<Input> inputs, TreeNode parentNode = null)
        {
            TreeNode rootNode = null;

            // Build a dictionary to store each input and its node
            var dict = inputs.ToDictionary(
                input => input.Id,
                input => new { 
                    Input = input, 
                    Node = new TreeNode(input.Id) 
                });

            // Iterate through the nodes and build relationship among them
            foreach (var value in dict.Values)
            {
                var input = value.Input;
                if (input.ParentId != null)    //If the ParentId is null, add it as root. If not, add it as a child.
                {
                    dict[(int)input.ParentId].Node.AddChild(value.Node);
                }
                else
                {
                    rootNode = value.Node;
                }
            }
            return rootNode;
            //throw new NotImplementedException();
        }
    }
}