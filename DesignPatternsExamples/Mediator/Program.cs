using System;

namespace Mediator
{
    /// <summary>
    /// TODO:
    /// Flush out more. Maybe onlineStore\Catalog\Cart setup.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public interface IMediator
        {
            public void Interaction();
        }

        public class Mediator : IMediator
        {
            public Piece piece;
            public Part part;
            public Thing thing;

            public Mediator()
            {

            }

            public void Interaction()
            {
                throw new NotImplementedException();
            }
        }

        public class Piece
        {
            IMediator mediator;
            public Piece(IMediator mediator) => this.mediator = mediator;

            public void Invoke()
            {
                mediator.Interaction();
            }
        }

        public class Part
        {
            IMediator mediator;
            public Part(IMediator mediator) => this.mediator = mediator;

            public void Invoke()
            {
                mediator.Interaction();
            }
        }

        public class Thing
        {
            IMediator mediator;
            public Thing(IMediator mediator) => this.mediator = mediator;
            
            public void Invoke()
            {
                mediator.Interaction();
            }
        }
    }
}
