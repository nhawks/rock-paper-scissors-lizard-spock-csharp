using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
