using System;

namespace Monad
{
    /// <summary>
    /// Functional programming, glue + container
    /// Abstraction is some kind of behavior I want to handle - io/null/state/try/flatten.
    /// 
    /// async/await/task ia a monad         => await to unpack the value
    /// .SelectMany is a monad (flatten)    => List<T>.SelectMany(Func<T, List<T>> f).SelectMany(Func<T, List<T>> f)
    /// wrapping try catch function         => unpack the value after exception happens
    /// logging/state accumilation function => log application is seperate from the function
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            //string foo = null;
            //string foo = "Hello World!";

            #region First
            //if (foo != null)
            //    foo = foo.Trim();
            //
            //if (foo != null)
            //    foo = foo.Substring(0, 5);
            #endregion

            #region Second
            //int n = foo == null ? 0 : foo.Length;
            //n = n * n;
            //
            //Console.WriteLine(n);
            //Console.ReadLine();
            #endregion

            #region Third
            string foo = "Hello World!";
            // The '?' operator is a monad, c# wraps behind the scenes (syntactic sugaring)
            int nn = foo?.Trim()?.Substring(0, 5)?.Length ?? 0;
            nn = nn * nn;

            Console.WriteLine(nn);
            Console.ReadLine(); 
            #endregion
        }
    }
}
