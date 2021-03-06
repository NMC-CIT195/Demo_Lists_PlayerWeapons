﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lists_PlayerWeapons
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO 00a instantiate a player


            // TODO 03b call the method to demonstrate weapons list management


        }

        // TODO 03a add a method to demonstrate weapons list management
        /// <summary>
        /// demonstrate listing, adding, and removing a weapon from the player's weapon list
        /// </summary>
        /// <param name="myPlayer">Player Object</param>
        public static void DemoWeaponManagement(Player myPlayer)
        {
            // TODO 04d call the method to initialize the player's weapons list


            // TODO 05b call the method to display the player's weapons list


            // TODO 06b create a new weapon and add it to the player's weapons list
            // create and add a new laser weapon

            // TODO 06c display the player's weapons list


            // TODO 07b choose and remove a weapon to the player's weapons list
            // remove a weapon


            // TODO 07c display the player's weapons list


            Console.WriteLine("Press the Enter key to continue.");
            Console.ReadLine();
        }


        // TODO 04a add a method to initialize the player's weapons list
        /// <summary>
        /// add weapons to the players list of weapons
        /// </summary>
        /// <param name="myPlayer">Player Object</param>
        public static void InitializePlayerWeapons(Player myPlayer)
        {
            // TODO 04b add a weapon by first instantiating one

            // TODO 04c add a weapon using a list initializer

        }

        // TODO 05a add a method to display the player's weapons list
        /// <summary>
        /// display all of the player's weapons in the player's list of weapons
        /// </summary>
        /// <param name="myPlayer">Player Object</param>
        public static void DisplayPlayersWeapons(Player myPlayer)
        {
            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("The Player has the following weapons:");
            Console.WriteLine();

            foreach (Weapon weapon in myPlayer.Weapons)
            {
                Console.WriteLine("Weapon Name: " + weapon.Name);
                Console.WriteLine("Weapon Type: " + weapon.Type);
                Console.WriteLine("Weapon Description: " + weapon.Description);
                Console.WriteLine("");
            }

            Console.ReadLine();
        }

        // TODO 06a add a method to add a weapon to the player's weapons list
        /// <summary>
        /// add a weapon the player's weapon list
        /// </summary>
        /// <param name="myPlayer"></param>
        /// <param name="weapon"></param>
        public static void AddWeaponToPlayer(Player myPlayer, Weapon weapon)
        {

        }

        // TODO 07a add a method to remove a weapon to the player's weapons list
        /// <summary>
        /// remove a weapon from the player's weapon list
        /// </summary>
        /// <param name="myPlayer">Player Object</param>
        /// <param name="weaponName">weapon to remove</param>
        public static void RemoveWeaponFromPlayer(Player myPlayer, string weaponName)
        {
            // set default value to -1 to indicate that the weapon was not found in the list
            int weaponIndex = -1;



            // use lambda operator
            // weaponIndex = myPlayer.Weapons.FindIndex(c => c.Name == weaponName);

            Console.WriteLine("Remove the weapon with index = " + weaponIndex);
            Console.WriteLine("Press the Enter key to continue.");

            //myPlayer.Weapons.RemoveAt(weaponIndex);
        }
    }
}
