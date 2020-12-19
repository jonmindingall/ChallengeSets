using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;
            while (startNumber % n != 0)
            {
               startNumber++;
            }
            
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {

            foreach (var item in businesses)
            {
                if (item.TotalRevenue == 0)
                {
                    item.Name = "CLOSED";
                }
            }


        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int total = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 2 == 0) && (i+1) < (numbers.Length))
                {
                    total += numbers[i + 1];
                }
            }
            return total;
            

            
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
            string newSentence = null;
            if (words == null || words.Length == 0)
            {
                return "";
            }
            
            foreach (var item in words)
            {
                if (item != " ")
                {
                    string newItem = item.Replace(" ", String.Empty);
                    sentence += (newItem + ' ');
                }
                                     
            }
            if (sentence == "" || sentence == " ")
            {
                return "";
            }
            else
            {
                newSentence = Regex.Replace(sentence, " {2,}", " ");
                return newSentence.Trim() + '.';
            }
            
            
            


        }
            
            



        

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var returnable = new List<double>();
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            
            for (int i = 0; i <= elements.Count; i++)
            {
                if ((i > 0) && (i % 4 == 0))
                {
                    returnable.Add(elements[i-1]);
                }
            }
            double[] newArray = returnable.ToArray();
            return newArray;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = 0; k < nums.Length; k++)
                {
                    if (i != k)
                    {
                        int sum = nums[i] + nums[k];
                        if (sum == targetNumber)
                        {
                            return true;
                        }
                            
                    }
                }
            }
            return false;
        }
        
    }
}
