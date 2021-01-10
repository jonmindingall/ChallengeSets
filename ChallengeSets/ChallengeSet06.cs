using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            var valueToReturn = false;
            if (words == null || word == null)
            {
                return false;
            }
            else
            {
                foreach (var item in words)
                {
                    if (ignoreCase && item != null)
                    {
                        if (item.ToLower() == word.ToLower())
                        {
                            return true;
                        }
                        else
                        {
                            valueToReturn = false;
                        }
                        
                    
                    }
                    else
                    {
                        if (item == word)
                        {
                            return true;
                        }
                        else
                        {
                            valueToReturn = false;
                        }
                        
                            
                    }
                    
                }
                return valueToReturn;

            }
            
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
                

            return true;

           
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
