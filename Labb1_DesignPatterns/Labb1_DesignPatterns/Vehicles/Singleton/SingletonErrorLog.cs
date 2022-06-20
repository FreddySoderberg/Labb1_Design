using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_DesignPatterns.Vehicles.Singleton
{
    public sealed class SingletonErrorLog
    {
        private static int counter = 0;
        private static SingletonErrorLog instance = null;
        public static SingletonErrorLog GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonErrorLog();
                return instance;
            }
        }

        private SingletonErrorLog()
        {
            counter++;
        }

        public void WrongInputMessage()
        {
            Console.WriteLine("Wrong input, try again.");
        }
    }
}
