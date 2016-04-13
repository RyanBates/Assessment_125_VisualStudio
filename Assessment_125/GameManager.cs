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
    [Serializable]
    [XmlSerializerAssembly]
    public class GameManager : IGameManager
    {
        private Party m_hero;
        private Party m_villian;

        public Party Hero
        {
            get { return m_hero; }
            set { m_hero = value; }
        }

        public Party Villian
        {
            get { return m_villian; }
            set { m_villian = value; }
        }

        public Party CreateParty(Party create, string type)
        {
            throw new NotImplementedException();
        }

        public States ChangeStation()
        {
            throw new NotImplementedException();
        }

        GameManager IGameManager.GameControl()
        {
            throw new NotImplementedException();
        }
    }
}
