using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class LinkedList<T>
    {
        public Node _node { get; set; }

        public class Node
        {
            public Node Next { get; set; }
            public T Value { get; set; }

            public void Append(T value)
            {
                if (Next == null)
                {
                    Next = new Node { Value = value };
                    return;
                }
                Next.Append(value);
            }

            public T Get(int i) => i == 0 ? Value : Next.Get(--i);
        }

        public void Add(T value)
        {
            if (_node == null)
            {
                _node = new Node { Value = value };
                return;
            }
            _node.Append(value);
        }

        public T Get(int i) => _node.Get(i);

        public LinkedIterator Iterator => new LinkedIterator(_node);

        /// <summary>
        /// This is a concrete implementation!
        /// Real iterators are abstract and is used over multiple types of collections (basically, IEnumerable).
        /// </summary>
        public class LinkedIterator
        {
            private Node _root;
            private Node _current;

            public LinkedIterator(Node root) => _root = _current = root;

            public T Next()
            {
                var value = _current.Value;
                _current = _current.Next;
                return value;
            }

            public bool IsComplete => _current == null;

            public void Reset()
            {
                _current = _root;
            }
        }
    }
}
