using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Hashtable singletons = new Hashtable();
        public static Singleton GetInstance(int id)
        {
            if (id >= 0 && id < 3)
            {
                if (!singletons.ContainsKey(id))
                {
                    Singleton singleton = new Singleton();
                    singletons.Add(id, singleton);
                }
                return singletons[id] as Singleton;
            }
            id = id % 3;
            return singletons[id] as Singleton;
        }
    }
}
