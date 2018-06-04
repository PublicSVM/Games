using ConsoleGames.Games;
using Psvm.ConsoleGames;

namespace ConsoleGames
{
    internal class Program
    {
        private static void Main()
        {
            var gameMaster = new GameMaster();

            gameMaster.RegisterGame<MyFirstGame>(name: "one");
            gameMaster.RegisterGame<MySecondGame>(name: "another");

            gameMaster.Start();
        }
    }
}
