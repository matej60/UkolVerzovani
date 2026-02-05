using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            linQTest();

            Console.ReadKey();
        }
        public static void linQTest()
        {
            List<int> list = new List<int>() { 15, 2, 35, -1, 0, 20, 9, 17, 5, 4, -7 };
            IEnumerable<int> listOut =
                from num in list
                where num > 0 && num < 10
                select num;
            Console.WriteLine(string.Join(",", listOut) + " " + listOut.Count());

            var listOutLinQ = list.Where(x => x > 0 && x < 10);

            Console.WriteLine(string.Join(",", listOutLinQ) + " " + listOutLinQ.Count());

            IEnumerable<int> sortedInts = list.OrderBy(x => x);

            foreach (int i in sortedInts)
            {
                Console.Write(i + " ");
            }

            Console.Write("\n" + string.Join(", ", Enumerable.Range(1, 30)));
            Console.Write("\n" + string.Join(", ", sortedInts));

        }
    }
}
