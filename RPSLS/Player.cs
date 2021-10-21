using System;
using System.Collections.Generic;

namespace RPSLS
{
    public class Player
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
            do
            {
                Console.WriteLine("___________________________________________________________________");
                Console.WriteLine($"{name} pick a gesture: Rock | Paper | Scissors | Lizard | Spock");
                choice = Console.ReadLine().ToLower();
                GestureIsValid();
            }
            while (!gestureIsValid);
        }

        public void GestureIsValid()
        {
            if (gestures.Contains(choice))
            {
                gestureIsValid = true;
            }
            else
            {
                gestureIsValid = false;
                Console.WriteLine($"{name} Choice Invalid: That choice({choice}) was invalid!\nPlease check your spelling or choose a value from the list.");
            }
        }
    }
}