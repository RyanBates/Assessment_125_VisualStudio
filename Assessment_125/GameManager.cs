using System;
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
    public class GameManager : Unit, IGameManager
    {
        Unit Hero(string n, int h, int a, int s, int l, int xp)
        {

        }

        Unit Villian(string n, int h, int a, int s, int l, int xp)
        {

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

        void main()
        {

        }
    }



}