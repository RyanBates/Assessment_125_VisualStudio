using System;
using System.Collections.Generic;

namespace Finite_State_Machine
{
    /// <summary>
    /// is going from which state it
    /// is currently in then tells 
    /// when to switch to the next
    /// state in the game.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    class FSM<T>
    {
        class Transition
        {
            public T from;
            public T to;

            public Transition(T f, T t)
            {
                from = f;
                to = t;
            }
        }

        public List<T> _States;
        public List<T> transitionTable;

        public FSM(T state)
        {

        }

        public bool AddState(T state)
        {
            if (_States.Contains(state))
            {
                return false;
            }

            else
            {
                _States.Add(state);
                return true;
            }
        }

        public void AddTrans(T f, T t)
        {
            if (transitionTable.Contains(f))
            {
                transitionTable.Add(f);
            }
        }

        public void ChangeTrans(T f, T t)
        {
            if (transitionTable.Contains(t))
            {
                transitionTable.Add(f);
            }
        }
    }
}