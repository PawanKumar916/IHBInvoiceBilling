using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternExample
{
    public sealed class Singleton
    {
        private static int count = 0;
        //private static readonly object obj = new object();
        //private static Singleton instance = null;

        //Eger Loading
        //private static readonly Singleton instance = new Singleton();

        //Lazy Loading
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        public static Singleton GetInstance
        {
            get
            {
                //if (instance == null)
                //{
                //    lock (obj)
                //    {
                //        if (instance == null)
                //        {
                //            instance = new Singleton();
                //        }
                //    }
                //}
                //return instance;
                return instance.Value;
            }
        }
        private Singleton()
        {
            count++;
            Console.WriteLine("Singleton Counter Value is : " + count.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

}
