using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public abstract class ChessPiece
    {
        protected const int MAX_DISTANCE = 7;

        // Pawn fields
        protected bool canEnPassantLeft;
        protected bool canEnPassantRight;
        protected bool canDoubleJump;

        // Other fields
        protected bool canCastle; // For rooks and kings
        protected Point[][] availableMoves; // Array for moves ([direction][distance])
        protected Point[][] availableAttacks; // Same as Moves except pawn
        private int player;

        public Point[][] AvailableMoves
        {
            get { return availableMoves; }
        }

        public Point[][] AvailableAttacks
        {
            get { return availableAttacks; }
        }

        public int Player
        {
            get { return player; }
            set { player = value; }
        } 

        public abstract ChessPiece CalculateMoves();
        
        // Get relative horizontal or virtical movement coordinates, king , queen , pawn , rook
       
        // distance = How far in the given direction
        // direction = Direction relative to player
        // Returns an array for horizontal or vertical movement
        public static Point[] GetMovementArray(int distance, Direction direction)
        {
            Point[] movement = new Point[distance];
            int xPosition = 0;
            int yPosition = 0;

            for (int i = 0; i < distance; i++)
            {
                switch (direction)
                {
                    case Direction.FORWARD:
                        yPosition++;
                        break;
                    case Direction.BACKWARD:
                        yPosition--;
                        break;
                    case Direction.LEFT:
                        xPosition++;
                        break;
                    case Direction.RIGHT:
                        xPosition--;
                        break;
                    default:
                        break;
                }
                movement[i] = new Point(xPosition, yPosition);
            }
            return movement;
        }

    
        // Get relative diagonal movement coordinates used by king, queen, pawn, bishop
        public static Point[] GetDiagnalMovementArray(int distance, DiagnalDirection direction)
        {
            Point[] attack = new Point[distance];
            int xPosition = 0;
            int yPosition = 0;

            for (int i = 0; i < distance; i++)
            {
                switch (direction)
                {
                    case DiagnalDirection.FORWARD_LEFT:
                        xPosition--;
                        yPosition++;
                        break;
                    case DiagnalDirection.FORWARD_RIGHT:
                        xPosition++;
                        yPosition++;
                        break;
                    case DiagnalDirection.BACKWARD_LEFT:
                        xPosition--;
                        yPosition--;
                        break;
                    case DiagnalDirection.BACKWARD_RIGHT:
                        xPosition++;
                        yPosition--;
                        break;
                    default:
                        break;
                }
                attack[i] = new Point(xPosition, yPosition);
            }
            return attack;
        }
    }
}
