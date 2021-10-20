using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = new Player("Player One");
            Player playerTwo = new Player("Player Two");
            playerOne.PickGesture();
            playerTwo.PickGesture();
        }
    }
}
