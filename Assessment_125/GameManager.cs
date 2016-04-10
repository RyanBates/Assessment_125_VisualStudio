using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Characteristics;
using Fight;
using Finite_State_Machine;

namespace GameManager
{
    /// <summary>
    /// this will tell the game when the units
    /// will attack and when to switch the 
    /// changes.
    /// </summary>
    class GameManager : Interfaces.IGameManager
    {
        public Party Hero
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Party Villian
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Party CreateParty(Party create, string type)
        {
            throw new NotImplementedException();
        }

        public Interfaces.IGameManager GameControl()
        {
            throw new NotImplementedException();
        }

        public States ChangeStation()
        {
            throw new NotImplementedException();
        }
    }
}
