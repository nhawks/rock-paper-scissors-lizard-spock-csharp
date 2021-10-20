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
        public bool gestureIsValid;

        // Constructor (Generates)
        public Player(string playerName)
        {
            name = playerName;
        }

        // Methods (Can do)
        public virtual void PickGesture()
        {
            Console.WriteLine($"Current Choice: {choice}");
            Console.WriteLine("Pick a gesture: Rock | Paper | Scissors | Lizard | Spock");
            choice = Console.ReadLine();
        }
        // - validate choice
        public void GestureIsValid()
        {
            if (gestures.Contains(choice))
            {
                gestureIsValid = true;
            }
            else
            {
                gestureIsValid = false;
            }
        }
    }
}
