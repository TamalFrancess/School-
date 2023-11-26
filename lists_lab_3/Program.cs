using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists_lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4};
            List<int> list2 = new List<int> { 5, 6, 7 };

            List<int> resulList = MergeLists(list1, list2);


            
            foreach (int number in resulList)
            {
                Console.Write(number + " ");
            }
        }

        static List<int> MergeLists(List<int> list1, List<int> list2)
        {
            List<int> resultList = new List<int>();

            int maxLength = Math.Max(list1.Count, list2.Count);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < list1.Count)
                {
                    resultList.Add(list1[i]);
                }

                if (i < list2.Count)
                {
                    resultList.Add(list2[i]);
                }
            }
            return resultList;
        }
    }
}
