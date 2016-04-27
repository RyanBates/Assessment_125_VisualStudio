using System;
using System.Xml.Serialization;
using Characteristics;
using Fight;
using Finite_State_Machine;
using System.IO;

namespace GameManager
{
    /// <summary>
    /// this will tell the game when the units
    /// will attack and when to switch the 
    /// changes.
    /// </summary>
    [Serializable]
    [XmlSerializerAssembly]
    public class GameManager :  IGameManager
    {
        static private GameManager _stage;
        static public GameManager stage
        {
            get
            {
                if (_stage == null)
                    _stage = new GameManager();
                return _stage;
            }
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

    public class SaveLoad<T>
    {
        public SaveLoad() { }

        public void Serialize(string s, T t)
        {
            using (FileStream fs = File.Create(@"..\SavedFiles\" + s + ".xml"))
            {
                XmlSerializer serializser = new XmlSerializer(typeof(T));
                serializser.Serialize(fs, t);
            }
        }

        public T Deserialize(string s)
        {
            T t;
            using (FileStream fs = File.OpenRead(@"..\SavedFiles\" + s + ".xml"))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(T));
                t = (T)deserializer.Deserialize(fs);
                fs.Close();
            }
            return t;
        }
    }

}