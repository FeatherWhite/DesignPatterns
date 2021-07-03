using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Singleton
    {
        private static List<Singleton> singletons = new List<Singleton>();
        public static Singleton GetInstance(int id)
        {
            if (id >= 0 && id < 3)
            {
                Singleton singleton = new Singleton();
                singletons.Add(singleton);
                return singletons[id];
                //id++;
                //code = id;
            }
            return singletons[0];
        }
    }
}
