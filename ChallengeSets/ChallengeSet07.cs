using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            if ((businesses == null) || (businesses.Count == 0))
            {
                return 0;
            }

            var count = 0;

            foreach (var biz in businesses)
            {
                if ((biz.TotalRevenue - biz.TotalExpenses) < 0)
                {
                    count++;
                }
            }

            return count;
           
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            var profitableBusinesses = new List<string>();

            foreach (var biz  in businesses)
            {
                var profit = biz.TotalRevenue - biz.TotalExpenses;
                if (profit > 0)
                {
                    profitableBusinesses.Add(biz.Name);
                }
            }

            return string.Join(',', profitableBusinesses);
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            throw new NotImplementedException();
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            throw new NotImplementedException();
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
