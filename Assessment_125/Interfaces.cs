using System.Collections.Generic;
using GameManager;
using Fight;


namespace Characteristics
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
    /// this will take the class GameManager
    /// and determine when to change the scene 
    /// as well as when to save the game.
    /// </summary> 
    public interface IGameManager
    {
        Party CreateParty(Party create, string type);
        States ChangeStation();
        GameManager.GameManager GameControl();
    }

    /// <summary>
    /// this will create the team 
    /// and make them with diffrent 
    /// stats from the unit class
    /// as well as take from 
    /// GameManager to tell when they 
    /// go depending on that units 
    /// speed.
    /// </summary>
    public interface IGroup
    {
        List<Unit> team { get; set; }
        Unit cUnit { get; set; }            // states the cuurent unit.
        IGroup Attack(IGroup other);
    }
}