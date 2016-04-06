using System;
using System.Collections.Generic;
using Game;
using Characteristics;
using Finite;
using System.Xml.Serialization;

namespace Fight
{
    /// <summary>
    /// is the class that will 
    /// create all of the 
    /// characters that will be fighting 
    /// in the game.
    /// </summary>
    public class Unit : Interfaces.IStats
    {
        private string m_Name;
        private int m_HP;
        private int m_AP;
        private int m_S;
        private int m_Level = 1;
        private int m_XP = 0;

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public int Health
        {
            get { return m_HP; }
            set { m_HP = value; }
        }

        public int Attack
        {
            get { return m_AP; }
            set { m_AP = value; }
        }

        public int Speed
        {
            get { return m_S; }
            set { m_S = value; }
        }

        public int Level
        {
            get { return m_Level; }
            set { m_Level = value; }
        }
        
        public int XP
        {
           get { return m_XP; }
           set { m_XP = value; }
        }

        public Unit(string n, int hp, int ap, int s, int l, int xp)
        {
            m_Name = n;
            m_HP = hp;
            m_AP = ap;
            m_S = s;
            m_Level = l;
            m_XP = xp;
        }
    }

    /// <summary>
    /// takes the interface IGroup
    /// make the party and be able to 
    /// change which character will be
    /// attacking that turn and makeing
    /// them with the stats that are above
    /// while changing them as they level up.
    /// </summary>
    public class Party : Interfaces.IGroup 
    {

    }
}
