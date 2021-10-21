using System;

namespace RPSLS
{
    public class Game
    {
        // Member Variables (Has)
        public int roundCount;

        public int maxRounds;
        public int mode;
        public int playAgain;
        private GameRules rulesGraphic = new GameRules();
        private WinConditions winConditions = new WinConditions();

        // Constructor (Generates)
        public Game()
        {
            roundCount = 0;
            maxRounds = 0;
            mode = 0;
            RunGame();
        }

        // Methods (Can do)
        public void RunGame()
        {
            string gameContinue = "1";
            do
            {
                DisplayRules();
                GameMode();
                GeneratePlayers();
                RoundCountOption();
                StartRound();
                DisplayWinner();
                Console.WriteLine("Would you like to play again? Enter 1 for yes | Enter 2 for no.");
                gameContinue = Console.ReadLine();
            }
            while (gameContinue == "1");
        }

        public void DisplayRules()
        {
            Console.WriteLine(rulesGraphic.gameRules);
        }

        public void GameMode()
        {
            Console.WriteLine($@"
                Select a game mode:
                1 - Single Player
                2 - MultiPlayer"
                );
            mode = Convert.ToInt32(Console.ReadLine());
        }

        public void GeneratePlayers()
        {
            winConditions.playerList.CreatePlayers(mode);
        }

        public void RoundCountOption()
        {
            Console.WriteLine("Enter the number of rounds you'd like to play:\n");
            roundCount = Convert.ToInt32(Console.ReadLine());
            winConditions.HowManyWins(roundCount);
        }

        public void StartRound()
        {
            bool gameOver = false;
            int currentRound = 1;

            do
            {
                Console.WriteLine("____________________________________________________________");
                Console.WriteLine($"Round: {currentRound}/{roundCount}");
                GestureSelection();
                RoundResult();
                DisplayScore();
                currentRound += 1;
                gameOver = winConditions.WinConditionCheck();
            }
            while (!gameOver);
        }

        public void GestureSelection()
        {
            for (int i = 0; i < winConditions.playerList.playerList.Length; i++)
            {
                winConditions.playerList.playerList[i].PickGesture();
            }
        }

        public void RoundResult()
        {
            bool playerOneResult = winConditions.GestureComparison(
                winConditions.playerList.playerList[0].choice,
                winConditions.playerList.playerList[1].choice
                );

            if (playerOneResult)
            {
                winConditions.playerList.playerList[0].score++;
                Console.WriteLine("Round Winner: Player One! Score increased!");
            }
            else if (playerOneResult == false)
            {
                winConditions.playerList.playerList[1].score++;
                Console.WriteLine("Round Winner: Player Two! Score increased!");
            }
            else
            {
                Console.WriteLine("This round is a Draw!");
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine($"Player One Score: {winConditions.playerList.playerList[0].score} | {winConditions.playerList.playerList[1].score} Player Two Score:");
        }

        public void DisplayWinner()
        {
            if (winConditions.playerList.playerList[0].score > winConditions.playerList.playerList[1].score)
            {
                Console.WriteLine("WINNER: Player One!");
            }
            else if (winConditions.playerList.playerList[0].score < winConditions.playerList.playerList[1].score)
            {
                Console.WriteLine("WINNER: Player Two!");
            }
        }
    }
}