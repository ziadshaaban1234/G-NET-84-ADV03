using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_84_ADV03
{
    internal class ConsoleHelper
    {
        #region ConsoleHelper

        public static void PrintList<T>(string listName, List<T> items)
        {
            Console.WriteLine($"{listName} : [{string.Join(", ", items)}]");
        }

        public static void PrintHashSet<T>(string setName, HashSet<T> items)
        {
            Console.WriteLine($"{setName} : [{string.Join(", ", items)}]");
        }

        public static void PrintDictionary<TKey, TValue>(
            string dictName,
            IDictionary<TKey, TValue> items)
            where TKey : notnull
        {
            Console.WriteLine($"{dictName} :");

            foreach (var pair in items)
            {
                Console.WriteLine($"\t{pair.Key} : {pair.Value}");
            }
        }

        public static void PrintCollection<T>(
            string colName,
            IEnumerable<T> items)
        {
            Console.WriteLine($"{colName} : [{string.Join(", ", items)}]");
        }

        #endregion
    }
}