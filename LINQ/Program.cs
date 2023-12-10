using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 10, 20, 30, 40 };
            var nums2 = nums.Select(x => x / 2);
            Console.WriteLine(String.Join(" ", nums2));
            string[] nums3 = nums.Select(x => "num" + x).ToArray();
            Console.WriteLine(String.Join(" ", nums3));

            
        }
    }
}
