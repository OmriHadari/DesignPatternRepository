using System;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public partial class Computer
        {
            private IState _state = new Off();

            private void SetState(IState state)
            {
                _state = state;
            }

            public void PressPowerButton()
            {
                _state.PressPowerButton(this);
            }
        }

        public partial class Computer
        {
            private interface IState
            {
                void PressPowerButton(Computer computer);
            }

            private class Off : IState
            {
                public void PressPowerButton(Computer computer)
                {
                    // Preform work
                    computer.SetState(new On());
                }
            }

            private class On : IState
            {
                private bool charging;

                public void PressPowerButton(Computer computer)
                {
                    if (charging)
                        computer.SetState(new Standby());
                    else
                        computer.SetState(new Off());
                }
            }

            private class Standby : IState
            {
                public void PressPowerButton(Computer computer)
                {
                    computer.SetState(new On());
                }
            }
        }
    }
}
