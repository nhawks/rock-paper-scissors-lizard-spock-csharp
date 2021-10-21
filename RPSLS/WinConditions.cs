namespace RPSLS
{
    public class WinConditions
    {
        // Member Variables
        public int winsNeeded;

        public PlayerList playerList = new PlayerList();

        // Constructor
        public WinConditions()
        {
            winsNeeded = 0;
        }

        public bool GestureComparison(string playerOne, string playerTwo)
        {
            if (playerOne == "rock")
            {
                if (playerTwo == "scissors" || playerTwo == "lizard")
                {
                    return true;
                }
                else if (playerTwo == "paper" || playerTwo == "spock")
                {
                    return false;
                }
            }
            else if (playerOne == "paper")
            {
                if (playerTwo == "rock" || playerTwo == "spock")
                {
                    return true;
                }
                else if (playerTwo == "scissors" || playerTwo == "lizard")
                {
                    return false;
                }
            }
            else if (playerOne == "scissors")
            {
                if (playerTwo == "paper" || playerTwo == "lizard")
                {
                    return true;
                }
                else if (playerTwo == "rock" || playerTwo == "spock")
                {
                    return false;
                }
            }
            else if (playerOne == "lizard")
            {
                if (playerTwo == "spock" || playerTwo == "paper")
                {
                    return true;
                }
                else if (playerTwo == "rock" || playerTwo == "scissors")
                {
                    return false;
                }
            }
            else if (playerOne == "spock")
            {
                if (playerTwo == "scissors" || playerTwo == "rock")
                {
                    return true;
                }
                else if (playerTwo == "lizard" || playerTwo == "paper")
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return false;
        }

        public void HowManyWins(int rounds)
        {
            winsNeeded = (rounds / 2) + 1;
        }

        public bool WinConditionCheck()
        {
            for (int i = 0; i < playerList.playerList.Length; i++)
            {
                if (playerList.playerList[i].score == winsNeeded)
                {
                    return true;
                }
            }
            return false;
        }
    }
}