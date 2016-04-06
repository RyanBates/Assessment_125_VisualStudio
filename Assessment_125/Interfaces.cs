using System;
using System.Collections.Generic;
using Game;
using Fight;
using Finite_State_Machine;

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
        /// Created a interface which
        /// they will be able to both heal 
        /// the team and damage the other units when they 
        /// learn the magic skill after leveling up.
        /// </summary>
        public interface IMagic
        {
            int Cure { get; set; }
            int fire { get; set; }
            int ice { get; set; }
            int water { get; set; }
            int thunder { get; set; }
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