using System;
using static Monoid.Program;

namespace Monoid
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public struct Function<T>
        {
            public Func<T, T> run;

            public Function(Func<T, T> fn) => run = fn;

            // Then is a Monoid
            public Function<T> Then(Function<T> next)
            {
                var runCopy = run;
                return new(x => runCopy(next.run(x)));
            }

            // The + is a Monoid
            public static Function<T> operator +(
                Function<T> left,
                Function<T> right
                ) => new(x => left.run(right.run(x)));
        }
    }

    public static class FunctionExt
    {
        // Then is a Monoid
        public static Function<T> Then<T>(this Function<T> @this, Function<T> next)
        {
            return new(x => @this.run(next.run(x)));
        }
    }
}
