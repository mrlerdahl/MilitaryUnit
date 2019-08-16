using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class RunProgram
    {
        public RunProgram()
        {
            try
            {
                // Creates new military personnel setting their rank and name
                List<Personnel> militaryPersonnel = new List<Personnel>();
                militaryPersonnel.Add(new Personnel("PFC", "Ferguson", new Tank()));
                militaryPersonnel.Add(new Personnel("SGT", "Lerdahl", new Helicopter()));
                militaryPersonnel.Add(new Personnel("GYSGT", "Stone", new HMMWV()));
                militaryPersonnel.Add(new Personnel("CAPT", "Crunch", new Vehicle()));

                Console.WriteLine($"{militaryPersonnel[3].rank} {militaryPersonnel[3].lastName}: \"{militaryPersonnel[0].rank} {militaryPersonnel[0].lastName}" +
                    $" choose your weapon killer\"");
                Console.WriteLine($"{militaryPersonnel[0].rank} {militaryPersonnel[0].lastName}: \"Aye Aye Sir!!\"");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine($"{militaryPersonnel[0].ChooseWeapon(new BurstRifle())}\n");
                Console.WriteLine($"{militaryPersonnel[0].rank} {militaryPersonnel[0].lastName}: \"Ready to go Sir!\"");
                Console.WriteLine($"{militaryPersonnel[3].rank} {militaryPersonnel[3].lastName}: \"Excellent!\"");
                Console.WriteLine($"{militaryPersonnel[1].rank} {militaryPersonnel[1].lastName}: *Chuckles* \"Such a boot\"");
                Console.WriteLine($"{militaryPersonnel[2].rank} {militaryPersonnel[2].lastName}: *Elbows {militaryPersonnel[1].rank} {militaryPersonnel[1].lastName}*");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine($"{militaryPersonnel[3].rank} {militaryPersonnel[3].lastName}: \"{militaryPersonnel[1].rank} {militaryPersonnel[1].lastName}" +
                    $" choose your weapon motivator\"");
                Console.WriteLine($"{militaryPersonnel[1].rank} {militaryPersonnel[1].lastName}: \"Good to go Sir\"");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine($"{militaryPersonnel[1].ChooseWeapon(new RocketLauncher())}\n");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine($"{militaryPersonnel[3].rank} {militaryPersonnel[3].lastName}: \"{militaryPersonnel[2].rank} {militaryPersonnel[2].lastName}" +
                    $" choose your weapon\"");
                Console.WriteLine($"{militaryPersonnel[2].rank} {militaryPersonnel[2].lastName}: \"Yes Sir!\"");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine($"{militaryPersonnel[2].ChooseWeapon(new SemiAutoRifle())}\n");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine($"{militaryPersonnel[3].rank} {militaryPersonnel[3].lastName}: \"Ok gentlemen fire your weapons!\"\n");

                // looping through each personnel and their weapon
                for (int i = 0; i < militaryPersonnel.Count - 1; i++)
                {
                    Console.WriteLine($"{militaryPersonnel[i].rank} {militaryPersonnel[i].lastName} fires {militaryPersonnel[i].weaponOfChoice.WeaponType}");
                    militaryPersonnel[i].FireWeapon();
                    Console.WriteLine("");
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"{militaryPersonnel[3].rank} {militaryPersonnel[3].lastName}: \"Reload!\"\n");

                // looping through each personnel and their weapon
                for (int i = 0; i < militaryPersonnel.Count - 1; i++)
                {
                    Console.WriteLine($"{militaryPersonnel[i].rank} {militaryPersonnel[i].lastName} reloads {militaryPersonnel[i].weaponOfChoice.WeaponType}");
                    militaryPersonnel[i].LoadWeapon();
                    Console.WriteLine("");
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"{militaryPersonnel[3].rank} {militaryPersonnel[3].lastName}: \"Get in your vehicles!\"\n");

                // looping through each personnel and their vehicle
                for (int i = 0; i < militaryPersonnel.Count - 1; i++)
                {
                    Console.WriteLine($"{militaryPersonnel[i].rank} {militaryPersonnel[i].lastName} mounts {militaryPersonnel[i].givenVehicle.VehicleType}");
                    Console.WriteLine(militaryPersonnel[i].Mount());
                    Console.WriteLine("");
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"{militaryPersonnel[3].rank} {militaryPersonnel[3].lastName}: \"Now move!\"\n");

                // looping through each personnel and their vehicle
                for (int i = 0; i < militaryPersonnel.Count - 1; i++)
                {
                    Console.WriteLine($"{militaryPersonnel[i].rank} {militaryPersonnel[i].lastName} moves {militaryPersonnel[i].givenVehicle.VehicleType}");
                    Console.WriteLine(militaryPersonnel[i].Move());
                    Console.WriteLine("");
                }
            }
            // Catching any possible exceptions
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program has stopped");
            }

        }
    }
}
