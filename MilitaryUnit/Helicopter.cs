using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Helicopter : Vehicle
    {
        public override string VehicleType { get; } = "Helicopter";

        public override string MountMovement()
        {
            return $"Slides hatch open, hops in";
        }

        public override string DriveNoise()
        {
            return "Whup-Whup-Whup";
        }
    }
}
