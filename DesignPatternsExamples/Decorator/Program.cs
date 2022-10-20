using System;

namespace Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public interface IDumbData
        {
            int Id { get; set; }
            string Name { get; set; }
            string Description { get; set; }
        }

        public class DumbData : IDumbData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public abstract class BaseDecorator : IDumbData
        {
            protected IDumbData _data;

            public BaseDecorator(IDumbData data) => this._data = data;
            
            public virtual int Id { get => _data.Id; set => _data.Id = value; }
            public virtual string Name { get => _data.Name; set => _data.Name = value; }
            public virtual string Description { get => _data.Description; set => _data.Description = value; }
        }

        public class InjectedFunctioality : BaseDecorator
        {
            public InjectedFunctioality(IDumbData data) : base(data) { }

            public override string Name 
            { 
                get => base.Name;
                set
                {
                    _data.Name = value;
                    EmitEvent(value);
                }
            }

            public void EmitEvent(string name)
            {
                // Added functionality/responsibility is not known outside,
                // if favor of ability to pick decoration at runtime.
            }
        }
    }
}
