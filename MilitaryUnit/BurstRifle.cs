using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class BurstRifle : Weapon
    {
        public override string WeaponType { get; } = "Burst Rifle";

        // Prints the sound of weapon firing to the console
        public override void WeaponFiringNoise()
        {
            Console.WriteLine("PewPewPew... PewPewPew... PewPewPew");
        }

        // Prints the sound of weapon reloading to the console
        public override void LoadNoise()
        {
            Console.WriteLine("Release... swish... Click");
        }

        public void Draw()
        {
            Console.WriteLine("        |\\_______________(_____\\\\______________");
            Console.WriteLine("HH======#H###############H#######################");
            Console.WriteLine("         ' ~\"\"\"\"\"\"\"\"\"\"\"\"\"\"`##(_))#H\"\"\"\"\"Y########");
            Console.WriteLine("                           ))   \\#H\\       `\"Y###");
            Console.WriteLine("                           \"     }#H)");
        }
    }
}
