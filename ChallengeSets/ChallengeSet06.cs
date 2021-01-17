using System;
using System.Collections.Generic;
using System.Linq;

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
            return str.IndexOf(
                        str.Distinct()
                                .Reverse()
                                .Where(x => str.Where(y => y.Equals(x)).Count() == 1)
                                .FirstOrDefault());
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var newList = new List<double>();
            if ((n <= 0) || (elements == null))
            {
                return newList.ToArray();
            }
            for (int i = n-1; i < elements.Count(); i+=n)
            {
                newList.Add(elements[i]);
            }

            return newList.ToArray();
        }
    }
}

