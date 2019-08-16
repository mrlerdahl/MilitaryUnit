using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class RocketLauncher : Weapon
    {
        public override string WeaponType { get; } = "Rocket Launcher";

        // Prints noise of weapon firing to the console
        public override void WeaponFiringNoise()
        {
            Console.WriteLine("shhhwooosshh... KABOOOOM!!");
        }

        // Prints the reloadling noise to the console
        public override void LoadNoise()
        {
            Console.WriteLine("*Rocket Launcher reload noise*");
        }

    }
}
