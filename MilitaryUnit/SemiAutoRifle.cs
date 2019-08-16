using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class SemiAutoRifle : Weapon
    {
        public override string WeaponType { get; } = "Semi Automatic Rifle";

        // Prints the sound of weapon fireing to the console
        public override void WeaponFiringNoise()
        {
            Console.WriteLine("Pew Pew Pew Pew Pew");
        }

        // Prints the sound of weapon reloading to the console
        public override void LoadNoise()
        {
            Console.WriteLine("Release... swish... Click");
        }
    }
}
