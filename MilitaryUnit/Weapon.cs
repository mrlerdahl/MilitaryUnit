using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Weapon
    {
        public virtual string WeaponType { get; } = "Weapon";

        // Prints the sounds of weapon to the console
        public virtual void WeaponFiringNoise()
        {
            Console.WriteLine("Pew Pew");
        }

        // prints the sound of weapon reload to the console
        public virtual void LoadNoise()
        {
            Console.WriteLine("Loading weapon noise");
        }


    }
}
