namespace Chess.Engine;
public class ChessEngine
{
    const int BOARD_SQUARE_NUM = 120; 
    enum PiecesType
    {
        EMPTY, 
        wP, 
        wN, 
        wB, 
        wR, 
        wQ, 
        wK, 
        bP, 
        bN, 
        bB, 
        bR, 
        bQ, 
        bK, 
    }

    enum Columns
    {
        A, B, C, D, E, F, G, H, NONE
    }

    enum Rows
    {
        FILE_1, FILE_2, FILE_3, FILE_4, FILE_5, FILE_6, FILE_7, FILE_8, NONE 
    }

    enum Colors
    {
        WHITE, BLACK, BOTH
    }

    enum Squares
    {
        A1 = 21, B1, C1, D1, E1, F1, G1, H1,
        A2 = 31, B2, C2, D2, E2, F2, G2, H2,
        A3 = 41, B3, C3, D3, E3, F3, G3, H3,
        A4 = 51, B4, C4, D4, E4, F4, G4, H4,
        A5 = 61, B5, C5, D5, E5, F5, G5, H5,
        A6 = 71, B6, C6, D6, E6, F6, G6, H6,
        A7 = 81, B7, C7, D7, E7, F7, G7, H7,
        A8 = 91, B8, C8, D8, E8, F8, G8, H8, EMPTY_SQUARE
    }

    enum Booleans
    {
        TRUE, FALSE
    }

    public class Board
    {
        public int[] pieces = new int[BOARD_SQUARE_NUM];
        public ulong[] pawns {get;} = new ulong[3];
        public int[] kingSquare = new int[2];
        public int side;
        public int[]? enPassant;
        public int fiftyMoves; 
        //In two-or-more-player sequential games, a ply is one turn taken by one of the players. 
        public int ply; 
        public int historyPlay; 
        //unique key generated for each position
        public ulong positionKey; 

        public int[] piecesNumber = new int[13];
        //every piece which is not a pawn
        public int[] bigPieces = new int[3]; 
        //major pieces: rooks and queen
        public int[] majorPieces = new int[3]; 
        //minor pieces: bishop and knight
        public int[] minorPieces = new int[3]; 
    }

    public string HelloWorld()
    {
        
        return "Hello from the engine";
    }
}