using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();

            player.GoForward();
            player.GoForward();
            player.GoForward();
            player.GoBackward();
            player.GoBackward();
            player.GoForward();
            player.GoForward();
            player.GoBackward();

            Console.ReadLine();
        }

        public class Player
        {
            List<Position> positionsMemory = new();
            Position.Piece piece = new();

            public void GoForward()
            {
                // Dice roll
                var position = piece.GetPosition();
                positionsMemory.Add(position);

                int n = new Random().Next(1, 6);
                piece.Move(n);
            }

            public void GoBackward()
            {
                var position = positionsMemory.Last();
                positionsMemory.Remove(position);
                piece.SetPosition(position);
            }
        }

        public struct Position
        {
            private int Cell { get; set; }
            
            public class Piece
            {
                // Starting at
                public Position _position = new Position() { Cell = 0 };

                // Moving to
                public void Move(int n)
                {
                    Console.WriteLine("Moving from cell " + _position.Cell.ToString());
                    _position.Cell += n;
                    Console.WriteLine("Moving to cell " + _position.Cell.ToString());
                    Console.WriteLine();
                }

                public Position GetPosition() => new Position { Cell = _position.Cell };

                // Going back to
                public void SetPosition(Position p)
                {
                    Console.WriteLine("Moving from cell " + _position.Cell.ToString());
                    _position.Cell = p.Cell;
                    Console.WriteLine("Moving back to cell " + p.Cell.ToString());
                    Console.WriteLine();
                }
            }
        }

        
    }
}
