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
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {

            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
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
