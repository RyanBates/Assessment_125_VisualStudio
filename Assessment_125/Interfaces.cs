using System;
using System.Collections.Generic;
using Game;
using Fight;
using Finite;

namespace Characteristics
{
    class Interfaces
    {
        /// <summary>
        /// this is the part that will be 
        /// Defining the characters in
        /// the game.
        /// </summary>
        public interface IStats
        {
            string Name { get; set; }
            int Health { get; set; }
            int Attack { get; set; }
            int Speed { get; set; }
            int Level { get; set; }
            int XP { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public interface IGameManager
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public interface IGroup
        {

        }
    }
}