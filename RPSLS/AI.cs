using System;

namespace RPSLS
{
    public class AI : Player
    {
        // Constructor
        public AI(string name) : base(name)
        {
        }

        // Methods
        public override void PickGesture()
        {
            Random randomIndex = new Random();
            int index = randomIndex.Next(gestures.Count);
            choice = gestures[index];
        }
    }
}