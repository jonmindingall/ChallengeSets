using System;
using System.Collections.Generic;
using System.Linq;

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
            Business company = business;
            while (company.ParentCompany != null)
            {
                company = company.ParentCompany;
            }

            return company.Name;
            
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            throw new NotImplementedException();
        }


        //{
        //    var backDiagonal = new List<char>();

        //    backDiagonal.Add(finalBoard[0, 2]);
        //    backDiagonal.Add(finalBoard[1, 1]);
        //    backDiagonal.Add(finalBoard[2, 0]);

        //    for (int i = 0; i < 3; i++)
        //    {
        //        var vertLine = new List<char>();
        //        var horzLine = new List<char>();
        //        var fordDiagonal = new List<char>();
        //    }
        //}

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            bool flag = true;

            foreach (var items in numbers)
            {
                if (!items.Contains(targetNumber))
                {
                    flag = false;
                }
            }

            return flag;

        }
    }
}
