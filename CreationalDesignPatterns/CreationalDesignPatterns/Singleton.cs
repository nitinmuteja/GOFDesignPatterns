using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Singleton
{
    public sealed class Singleton
    {

        private static readonly Singleton INSTANCE = new Singleton();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return INSTANCE;
            }
        }
    }
}
