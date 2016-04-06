using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Characteristics;
using Finite_State_Machine;

namespace Game
{
    /// <summary>
    /// this will tell the game when the units
    /// will attack and when to switch the 
    /// changes.
    /// </summary>
    class GameManager : FSM<Task>, Interfaces.IGameManager
    {

    }
}
