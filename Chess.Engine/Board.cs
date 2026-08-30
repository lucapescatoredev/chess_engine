namespace Chess.Engine;
    public class Board
    {
        public static readonly int BOARD_SQUARE_NUM = 120; 
        public static readonly int MAX_GAME_MOVES = 2048;
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
        public int castlingRights; 
        public UndoMove[] history = new UndoMove[MAX_GAME_MOVES];
        //piece list:  
        // 13: every piece type (from wP to bK),
        // 10: we can have at most 10 pieces for each type 
        // (example: if I promote every single pawns to a knight, there will be at most 10 (2 + 8) knights on the board) 
        public int[,] pieceList = new int[13, 10];

    }

    public class UndoMove
    {
        int move; 
        int castlingRights;
        int enPassant;
        int fiftyMoves; 
        ulong positionKey;
    }

