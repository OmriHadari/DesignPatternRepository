using System;

namespace Command
{
    /// <summary>
    /// TODO:
    /// Expend. Paint app.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        interface ICommand
        {
            void Execute();
        }

        class HighlightText : ICommand
        {
            // text is the reciever
            public HighlightText(string text)
            {

            }

            public void Execute()
            {
                // highlight text range
            }
        }

        class BoldText : ICommand
        {
            // text is the reciever
            public BoldText(string text)
            {

            }

            public void Execute()
            {
                // bold text range
            }
        }

        // Button is the decoupling, this class shouldn't know the reciever or the operation
        class Button
        {
            ICommand command;
            public Button(ICommand command) => this.command = command;

            public void Click() => command.Execute();
        }
    }
}
