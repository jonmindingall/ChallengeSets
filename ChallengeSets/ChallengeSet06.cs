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
            throw new NotImplementedException();
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
