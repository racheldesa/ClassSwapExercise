using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSwapExercise
{
    class Elephant
    {
        private string Name;
        private int EarSize;

        public Elephant(string name, int earSize)
        {
            this.Name = name;
            this.EarSize = earSize;
        }

        public string WhoAmI()
        {
            return "My name is " + this.Name + ".\nMy ears are " + this.EarSize + " inches tall.\n";
        }
    }
}
