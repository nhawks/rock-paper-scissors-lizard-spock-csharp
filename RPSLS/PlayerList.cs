using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class PlayerList
    {
        public Player [] playerList = new Player[2];

        public void CreatePlayers(int mode)
        {
            if (mode == 1)
            {
                Human playerOne = new Human("Player One");
                AI playerAI = new AI("Player Two");
                playerList[0] = playerOne;
                playerList[1] = playerAI;
            }

            else if (mode == 2)
            {
                Human playerOne = new Human("Player One");
                Human playerTwo = new Human("Player Two");
                playerList[0] = playerOne;
                playerList[1] = playerTwo;
            }
        }
    }
}