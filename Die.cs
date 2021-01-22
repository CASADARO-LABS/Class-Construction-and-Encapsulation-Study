using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcapsulationStudyWithDieClass
{
    /// <summary>
    /// "Die" represents and individual die.
    /// </summary>
    class Die
    {
        // static fields are shared across all instances of a class
        static Random rand;
        byte minValue;
        byte maxValue;

        static Die() //static constructors are called once for class instances. 
        {
            rand = new Random();
         
        }

        public Die():this(1, 6)
        {
            //byte minValue = 1;
            //byte maxValue = 6;
            Roll();
        }

        /// <summary>
        /// Creates a die with numbers;
        /// between the min and max values.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound</param>
        /// <param name="maxValue">The inclusive upper bound</param>
        public Die(byte minValue, byte maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            Roll();
        }
        public byte Value { get; private set; }

        public bool IsHeld { get; set; }

        /// <summary>
        /// Roll a new random value between 1 and 6
        /// return the newly rolled value.
        /// If the die is held; 
        /// the current value of the die is return;
        /// no new value is generated.
        /// </summary>
        public byte Roll()
        {
            //if Die not held generate randon number;
            //otherwise, return the current Die value.
            if (!IsHeld) 
            {   
                // maxValue + 1 is used because the upperbound is exclusive.
                Value = (byte)rand.Next(minValue, maxValue + 1);
            }
            return Value;
        }
    }
}
