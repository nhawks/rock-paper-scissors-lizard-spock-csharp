using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        // Member Variables (Has)
        public string name;
        public string choice;
        public int score;
        public List<string> gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };

        // Constructor (Generates)
        public Player(string playerName)
        {
            name = playerName;
           
        }

        // Methods (Can do)

        public void pickGesture(string gesture)
        {
            Console.WriteLine(gestures.Contains(gesture));
        }

    }
}
