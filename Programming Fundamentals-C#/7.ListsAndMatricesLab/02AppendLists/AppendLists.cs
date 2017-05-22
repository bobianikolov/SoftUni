using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('|').ToList();
            List<string> ListReverse = new List<string>(list.Count);
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                string[] arr = list[i].Split(' ');
                foreach (var item in arr)
                {
                    if (item != "")
                    {
                        ListReverse.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", ListReverse));
        }
    }
}
