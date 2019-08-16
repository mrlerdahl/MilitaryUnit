using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{   
    class Personnel
    {
        public readonly string lastName;
        public readonly string rank;
        public Weapon weaponOfChoice { get; private set; }
        public Vehicle givenVehicle { get; private set; }

        public Personnel(string getRank, string getLastName, Vehicle vehicle)
        {
            rank = getRank;
            lastName = getLastName;
            givenVehicle = vehicle;
        }
        // Passes a weapon object setting the weaponOfChoice and printing to the screen rank name, and weapon picked
        public string ChooseWeapon(Weapon pickWeapon)
        {
            this.weaponOfChoice = pickWeapon;
            return $"{this.rank} {this.lastName} chose: {pickWeapon.WeaponType}";
        }
        // Depending on weapon of choice it will call the firing noise
        public void FireWeapon()
        {
            weaponOfChoice.WeaponFiringNoise();
        }
        // will call the loading noise of weapon
        public void LoadWeapon()
        {
            weaponOfChoice.LoadNoise();
        }
        // will call the type of movment required to get into vehicle
        public string Mount()
        {
            return $"{givenVehicle.MountMovement()}";
        }

        public string Move()
        {
            return $"{givenVehicle.DriveNoise()}";
        }
    }
}
