using System;
using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Real world example
            var list = new LinkedList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            Console.WriteLine(list.Get(0).ToString());
            Console.WriteLine(list.Get(1).ToString());
            Console.WriteLine(list.Get(2).ToString());
            Console.WriteLine(list.Get(3).ToString());
            Console.WriteLine(list.Get(4).ToString());
        }

        #region SimpleExample
        //public interface IComponent
        //{
        //    IList<IComponent> Children { get; }
        //}
        //
        //public class RegularComponent : IComponent
        //{
        //    public string Name = nameof(RegularComponent);
        //    public IList<IComponent> Children => null;
        //}
        //
        //public class OrdinaryComponent : IComponent
        //{
        //    public string Name = nameof(OrdinaryComponent);
        //    public IList<IComponent> Children => null;
        //}
        //
        //public class CompositeComponent : IComponent
        //{
        //    public string Name => nameof(CompositeComponent);
        //    public IList<IComponent> Children => new List<IComponent>()
        //    {
        //        new RegularComponent(),
        //        new OrdinaryComponent(),
        //        new CompositeComponent()
        //    };
        //} 
        #endregion

        #region RealWorldExample
        public class LinkedList<T>
        {
            public LinkedList() { }
            public LinkedList(T v) => value = v;
            
            T value;
            LinkedList<T> _next;

            public T Get(int i)
            {
                if (_next == null)
                    throw new IndexOutOfRangeException();

                if (i == 0)
                    return value;

                return _next.Get(--i);
            }

            public void Add(T v)
            {
                if (_next == null)
                {
                    value = v;
                    _next = new LinkedList<T>();
                }
                else
                {
                    _next.Add(v);
                }
            }
        }


        #endregion
    }
}
