using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_84_ADV03
{
    internal class Exercise02
    {
        #region Exercise02

        public static void Run()
        {
            Console.WriteLine(
                "\n==================== Exercise 02 : Leaderboard ===================="
            );

            SortedDictionary<int, string> Leaderboard = new()
            {
                [500] = "Ahmed",
                [200] = "Sara",
                [800] = "Ali",
                [350] = "Mona"
            };

            ConsoleHelper.PrintDictionary(
                "Leaderboard(Sorted By Score)",
                Leaderboard
            );

            Console.WriteLine(
                $"First Key(Lowest Score):{Leaderboard.Keys.First()}"
            );

            Console.WriteLine(
                $"First Value:{Leaderboard.Values.First()}"
            );

            Console.WriteLine(
                $"ContainsKey(500):{Leaderboard.ContainsKey(500)}"
            );

            if (Leaderboard.TryGetValue(999, out string? Player999))
            {
                Console.WriteLine($"Found:{Player999}");
            }
            else
            {
                Console.WriteLine("Score 999:Not Found");
            }

            Leaderboard.Remove(200);

            ConsoleHelper.PrintDictionary(
                "Leaderboard After Removing Score 200",
                Leaderboard
            );
        }

        #endregion
    }
}