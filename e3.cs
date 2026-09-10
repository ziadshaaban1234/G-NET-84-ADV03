using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_84_ADV03
{
    internal class Exercise03
    {
        #region Exercise03

        public static void Run()
        {
            Console.WriteLine(
                "\n==================== Exercise 03 : Phone Book ===================="
            );

            Dictionary<string, string> PhoneBook = new()
            {
                ["Ahmed"] = "01000000001",
                ["Sara"] = "01000000002",
                ["Ali"] = "01000000003",
                ["Mona"] = "01000000004"
            };

            PhoneBook["Laila"] = "01000000005";

            ConsoleHelper.PrintDictionary(
                "Phone Book After Adding Laila",
                PhoneBook
            );

            try
            {
                PhoneBook.Add("Ahmed", "01099999999");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(
                    $"Add(Ahmed) Error:{ex.Message}"
                );
            }

            bool TryAddResult =
                PhoneBook.TryAdd("Ahmed", "01099999999");

            Console.WriteLine(
                $"TryAdd(Ahmed):{TryAddResult}"
            );

            bool ContactExists =
                PhoneBook.ContainsKey("Hassan");

            Console.WriteLine(
                $"ContainsKey(Hassan):{ContactExists}"
            );

            string ContactNumber =
                PhoneBook.GetValueOrDefault(
                    "Hassan",
                    "Not Found"
                );

            Console.WriteLine(
                $"Hassan:{ContactNumber}"
            );

            Console.WriteLine(
                $"Keys:[{string.Join(", ", PhoneBook.Keys)}]"
            );

            Console.WriteLine(
                $"Values:[{string.Join(", ", PhoneBook.Values)}]"
            );
        }

        #endregion
    }
}