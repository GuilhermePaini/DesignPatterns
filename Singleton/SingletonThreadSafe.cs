using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class SingletonThreadSafe
    {
        private SingletonThreadSafe() { }

        private static SingletonThreadSafe? _instance;

        private static readonly object _lock = new object();

        public static SingletonThreadSafe Instance()
        {
            if(_instance == null)
            {
                lock(_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new SingletonThreadSafe();
                    }
                }
            }

            return _instance;
        }
    }
}
