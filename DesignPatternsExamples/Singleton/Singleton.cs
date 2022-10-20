using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    #region SingleThread
    // Sealed restricts the inheritance.
    // Without sealed keywork, a nested class can access the contructor, despite being private.

    // NOTICE!!! This vertion of the singleton design pattern is NOT thread safe! (single threaded)
    //public sealed class Singleton
    //{
    //    // To check how many times the contructor has been called. More than 1, not singleton.
    //    private static int counter = 0;
    //
    //    // Private constructor ensures that no one can instantiate this class othen the class itself.
    //    private Singleton()
    //    {
    //        counter++;
    //        Console.WriteLine("Counter value: " + counter.ToString());
    //    }
    //
    //    // GetInstance (the public static property) is used to return only one instance (the private property) of the class.
    //    private static Singleton instance = null;
    //    public static Singleton GetInstance
    //    {
    //        get
    //        {
    //            if (instance == null)
    //                instance = new Singleton();
    //            return instance;
    //        }
    //    }
    //
    //    public void PrintDetails(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //} 
    #endregion

    #region MultiThreadWithLock
    // Sealed restricts the inheritance.
    // Without sealed keywork, a nested class can access the contructor, despite being private.
    public sealed class Singleton
    {
        // To check how many times the contructor has been called. More than 1, not singleton.
        private static int counter = 0;
        // Lock mechanism
        private static readonly object obj = new object();

        // Private constructor ensures that no one can instantiate this class othen the class itself.
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value: " + counter.ToString());
        }
    
        // GetInstance (the public static property) is used to return only one instance (the private property) of the class.
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                // In order to avoid unnecessary locking, first check if a lock is required.
                if (instance == null)
                {
                    // If instance was not instantiated, lock.
                    lock (obj)
                    {
                        // Doublecheck instantiation.
                        if (instance == null)
                            // Create instance.
                            instance = new Singleton();
                    } 
                }

                // If instance was already instantiated, the previous instance will return.
                // Once the first threat locks, all other threads will wait till unlocked.
                return instance;
            }
        }
    
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    } 
    #endregion
}
