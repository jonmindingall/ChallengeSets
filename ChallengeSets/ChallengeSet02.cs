using System;
using System.Collections.Generic;
using System.Globalization;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {

            int total = 0;
            if (numbers != null)
            {
                foreach (var num in numbers)
                {
                    total += num;
                }
                return total;
            }
            else
            {
                return 0;
            }
            
        }

        public int SumEvens(int[] numbers)
        {
            int total = 0;
            if (numbers != null)
            {
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        total += num;
                    }
                }
                return total;
            }
            else
            {
                return 0;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int total = 0;
            if (numbers != null)
            {
                foreach (var num in numbers)
                {
                    total += num;
                }
                if (total % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
