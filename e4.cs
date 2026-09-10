using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_84_ADV03
{
    internal class Exercise04
    {
        #region Exercise04

        public static void Run()
        {
            Console.WriteLine(
                "\n==================== Exercise 04 : Unique Email Validator ===================="
            );

            HashSet<string> Emails = new(StringComparer.OrdinalIgnoreCase);

            Emails.Add("ahmed@test.com");
            Emails.Add("AHMED@test.com");
            Emails.Add("sara@test.com");
            Emails.Add("Sara@Test.Com");

            ConsoleHelper.PrintHashSet("Emails", Emails);

            Console.WriteLine($"Count:{Emails.Count}");

            Console.WriteLine(
                "Explanation:The HashSet Uses StringComparer.OrdinalIgnoreCase,So \"ahmed@test.com\"==\"AHMED@test.com\"" +
                "And \"sara@test.com\"==\"Sara@Test.Com\",Only 2 Unique Emails Are Actually Stored."
            );

            HashSet<int> SetA = [1, 2, 3, 4, 5];
            HashSet<int> SetB = [4, 5, 6, 7, 8];

            ConsoleHelper.PrintHashSet("Set A", SetA);
            ConsoleHelper.PrintHashSet("Set B", SetB);

            HashSet<int> Union = new(SetA);
            Union.UnionWith(SetB);

            ConsoleHelper.PrintHashSet("A UnionWith B", Union);

            HashSet<int> Intersect = new(SetA);
            Intersect.IntersectWith(SetB);

            ConsoleHelper.PrintHashSet("A IntersectWith B", Intersect);

            HashSet<int> Except = new(SetA);
            Except.ExceptWith(SetB);

            ConsoleHelper.PrintHashSet("A ExceptWith B", Except);

            HashSet<int> SubsetCheck = [1, 2];

            Console.WriteLine(
                $"{{1,2}}.IsSubsetOf(Set A):{SubsetCheck.IsSubsetOf(SetA)}"
            );
        }

        #endregion
    }
}