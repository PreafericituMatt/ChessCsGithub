using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Pawn : ChessPiece
    {
        public Pawn()
        {
            canDoubleJump = true;
            CalculateMoves();
        }

        public Pawn(int player)
        {
            Player = player;
            canDoubleJump = true;
            CalculateMoves();
        }
        
        // Create a new pawn.
        
        public Pawn(int player = 0, bool doubleJump = true, bool enPassantLeft = false, bool enPassantRight = false)
        {
            Player = player;
            canDoubleJump = doubleJump;
            canEnPassantLeft = enPassantLeft;
            canEnPassantRight = enPassantRight;
            CalculateMoves();
        }

        public override ChessPiece CalculateMoves()
        {
            Direction forward;
            DiagnalDirection forwardLeft, forwardRight;
            if (Player == 1)
            {
                forward = Direction.BACKWARD;
                forwardLeft = DiagnalDirection.BACKWARD_LEFT;
                forwardRight = DiagnalDirection.BACKWARD_RIGHT;
            }
            else
            {
                forward = Direction.FORWARD;
                forwardLeft = DiagnalDirection.FORWARD_LEFT;
                forwardRight = DiagnalDirection.FORWARD_RIGHT;
            }

            availableMoves = new Point[1][];
            if (canDoubleJump)
            {
                availableMoves[0] = GetMovementArray(2, forward);
            }
            else
            {
                availableMoves[0] = GetMovementArray(1, forward);
            }
            availableAttacks = new Point[2][];
            availableAttacks[0] = GetDiagnalMovementArray(1, forwardLeft);
            availableAttacks[1] = GetDiagnalMovementArray(1, forwardRight);
            return this;
        }

        public bool CanDoubleJump 
        {
            get
            {
                return canDoubleJump;
            }
            set
            {
                canDoubleJump = value;
            }
        }
        
        public bool CanEnPassantLeft
        {
            get
            {
                return canEnPassantLeft;
            }
            set
            {
                canEnPassantLeft = value;
            }
        }
        public bool CanEnPassantRight
        {
            get
            {
                return canEnPassantRight;
            }
            set
            {
                canEnPassantRight = value;
            }
        }
    }
}
