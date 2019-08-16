using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class HMMWV : Vehicle
    {
        public override string VehicleType { get; } = "HMMWV";

        // Prints the method of getting into the vehicle to the console
        public override string MountMovement()
        {
            return "Swings door open, hops in";
        }

        // Prints the driving noise of to the console
        public override string DriveNoise()
        {
            return "Brm brm";
        }
    }
}
