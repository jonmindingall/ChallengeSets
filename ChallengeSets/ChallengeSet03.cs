using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Cast<bool>().Contains(false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sumOfNumbers = 0;
            if (numbers != null)
            {
                foreach (var item in numbers)
                {
                    if (item % 2 != 0)
                    {
                        sumOfNumbers += item;
                    }
                }
                if (sumOfNumbers % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {

            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }
        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
