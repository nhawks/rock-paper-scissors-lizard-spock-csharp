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
            Human playerOne = new Human("Player One");
            Human playerTwo = new Human("Player Two");
            playerOne.PickGesture();
            playerTwo.PickGesture();
        }
    }
}
