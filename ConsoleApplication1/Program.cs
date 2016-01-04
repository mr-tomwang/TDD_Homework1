using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;



namespace ConsoleApplication1
{
    public class Table {

        private List<int> _Id;
        private List<int> _Cost;
        private List<int> _Revenue;
        private List<int> _SellPrice;

        public void SetIds(List<int> id)
        {
            _Id = id;
        }
        public void SetCosts(List<int> cost)
        {
            _Cost = cost;
        }
        public void SetRevenues(List<int> revenue)
        {
            _Revenue = revenue;
        }
        public void SetSellPrices(List<int> price)
        {
            _SellPrice = price;
        }
        public List<int> CreateGroups(string colName, int groupSize)
        {
            List<int> output = new List<int>();
            List<int> source = null;
            if (colName == "Revenue")
                source = _Revenue;
            else if (colName == "Cost")
                source = _Cost;
            if (source == null)
                return output;

            int sum = 0;
            int iterate = 0;
            for (int i = 0; i < source.Count; i++)
            {
                sum += source[i];
                iterate++;
                if (iterate == groupSize)
                {
                    output.Add(sum);
                    sum = 0;
                    iterate = 0;
                }
            }
            // check remaining one
            if (sum != 0)
            {
                output.Add(sum);
            }

            return output;
        }

    } 

    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();
            table.SetIds        (new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
            table.SetCosts      (new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
            table.SetRevenues   (new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 });
            table.SetSellPrices (new List<int> { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 });

            List<int> costGroup = table.CreateGroups("Cost", 3);
            List<int> revenueGroup = table.CreateGroups("Revenue", 4);
            Console.WriteLine("Done");
        }
    }
}
