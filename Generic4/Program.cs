using System;

namespace Generic4
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Test in case return null
            Console.WriteLine("{0} ", (null));

            // add data to list
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(1);
            list.Add(1230);
            // Test in case dose not return null
            Console.WriteLine("{0}", GetFirst(list));
        }

        private static int? GetFirst(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                return null;
            }
            return list[0];
        }
    }
}

