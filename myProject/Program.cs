using System;

namespace gamingStore
{
    class mygamingStore
    {
        static void Main(string[] args)
        {
            game game1 = new game();
            game1.SetTrans();
            game1.SetId(1);
            game1.SetTitle("Destiny 2");
            game1.SetStudio("Bungie");

            game game2 = new game();
            game2.SetTrans();
            Console.WriteLine("Please enter the game ID: ");
            game2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the game title: ");
            game2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the game studio: ");
            game2.SetStudio(Console.ReadLine());

            game game3 = new game(3, "Overwatch 2", "Blizzard");
            game3.SetTrans();

            Console.WriteLine("Please enter the game ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the game title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the game studio: ");
            string tempStudio = Console.ReadLine();
            game game4 = new game(tempID, tempTitle, tempStudio);
            game4.SetTrans();

            Console.WriteLine($"Number of transactions: {game.GetTotalTransactions()}");

            displayGames(game1);
            displayGames(game2);
            displayGames(game3);
            displayGames(game4);
        }

        class game
        {
            private int _Id;
            private string _Title;
            private string _Studio;
            private static int _Transactions = 0;

            public game()
            {
            }
            public game(int id, string title, string Studio)
            {
                _Id = id;
                _Title = title;
                _Studio = Studio;
            }
            public int GetTrans()
            {
                return _Transactions;
            }
            public void SetTrans()
            {
                _Transactions++;
            }
            public static int GetTotalTransactions()
            {
                return _Transactions;
            }
            public int GetId()
            {
                return _Id;
            }

            public void SetId(int id)
            {
                _Id = id;
            }

            public string GetTitle()
            {
                return _Title;
            }

            public void SetTitle(string title)
            {
                _Title = title;
            }

            public string GetStudio()
            {
                return _Studio;
            }

            public void SetStudio(string studio)
            {
                _Studio = studio;
            }
        }
        static void displayGames(game b)
        {
            Console.WriteLine("Video Game Information:");
            Console.WriteLine($"Video Game ID: {b.GetId()}");
            Console.WriteLine($"Video Game Title: {b.GetTitle()}");
            Console.WriteLine($"Video Game Studio: {b.GetStudio()}");
            Console.WriteLine();
        }
    }
}

