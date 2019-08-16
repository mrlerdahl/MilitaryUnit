using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Tank : Vehicle
    {
        public override string VehicleType { get; } = "Tank";

        // Prints the movement to get inside to the console
        public override string MountMovement()
        {
            return "Climbs up, lifts hatch, jumps down";
        }

        // Prints sound of tank moving
        public override string DriveNoise()
        {
            return "Rumble rumble rumble *big scary noise* rumble rumble rubmle";
        }
    }
}
