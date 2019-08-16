using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Vehicle
    {
        public virtual string VehicleType { get; } = "Vehicle";

        // prints the mount movement to the console
        public virtual string MountMovement()
        {
            return "Jumps in vehicle";
        }
        // prints the driving noise of vehicle to the console
        public virtual string DriveNoise()
        {
            return "brm brm";
        }
    }
}
