using System;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            
            foreach (var item in numbers)
            {
                
                if (item % 2 == 0)
                {
                    sum += item;
                }
                else
                {
                    sum -= item;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numArray = new int[4] { number1, number2, number3, number4 };
            return numArray.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }
            else if ((sideLength1 + sideLength2 > sideLength3) && (sideLength1 + sideLength3 > sideLength2) 
                 && (sideLength2 + sideLength3 > sideLength1)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                double evenSums = 0.00;
                double count = 0.00;
                foreach (var item in numbers)
                {
                    if (item % 2 == 0)
                    {
                        count ++;
                        evenSums += item;
                    }
                }
                if (count > 0)
                {
                    return evenSums / count;
                }
                else
                {
                    return 0;
                }
                
            }
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            int fact = 1;
            while (number != 1)
            {
                fact = fact * number;
                number--;
            }
            return fact;
        }
    }
}
