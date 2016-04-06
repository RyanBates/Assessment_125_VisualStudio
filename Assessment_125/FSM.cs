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
        private Dictionary<T, List<Transition>> transitionTable;

        public FSM()
        {
            _States = new List<T>();
            transitionTable = new Dictionary<T, List<Transition>>();
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
                transitionTable.Add(state, new List<Transition>());
                return true;
            }
        }

        public void AddTrans(T f, T t)
        {
            if (transitionTable.ContainsKey(f))
            {
                transitionTable[f].Add(new Transition(f, t));
            }
        }

        public void ChangeTrans(T f, T t)
        {
            if (transitionTable.ContainsKey(t))
            {
                transitionTable[t].Add(new Transition(f, t));
            }
        }
    }
}