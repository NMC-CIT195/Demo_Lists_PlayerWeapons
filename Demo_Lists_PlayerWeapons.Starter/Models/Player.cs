using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lists_PlayerWeapons
{
    /// <summary>
    /// Player class, inherits from Character class
    /// </summary>
    public class Player : Character
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS

        // TODO 02b add a field/property of list type to hold the player's weapons

        #endregion

        #region PROPERTIES
        

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// instantiate a player and set initial properties
        /// </summary>
        /// <param name="name">player name</param>
        public Player(
            string name)
            : base(name)
        {
            // TODO 02c instantiate the weapons list in the player constructor

        }

        #endregion

        #region METHODS



        #endregion
    }
}
