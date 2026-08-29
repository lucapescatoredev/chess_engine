namespace Chess.Engine;
public class ChessEngine
{
    private const int BOARD_SQUARE_NUM = 120; 
    private const int MAX_GAME_MOVES = 2048;
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
    _1,
    _2,
    _3,
    _4,
    _5,
    _6,
    _7,
    _8,
    NONE
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
    // 1 0 0 1
    enum CastlingRights  {
        WHITE_KING_CASTLE = 1, 
        WHITE_QUEEN_CASTLE = 2,
        BLACK_KING_CASTLE = 4, 
        BLACK_QUEEN_CASTLE = 8 
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
        public int castlingRights; 
        public UndoMove[] history = new UndoMove[MAX_GAME_MOVES];
    }
    public class UndoMove
    {
        int move; 
        int castlingRights;
        int enPassant;
        int fiftyMoves; 
        ulong positionKey;
    }
    
    int[] Square120ToSquare64 = new int[BOARD_SQUARE_NUM];
    int[] Square64ToSquare120 = new int[64];
    private int GetSquareCoords(int row, int column) 
    {
        return 21 + column + (row * 10);
    }
    private void InitSquare120To64()
    {
        int column_A = (int)Columns.A;
        int column_H = (int)Columns.H;
        int row_1 = (int)Rows._1;
        int row_8 = (int)Rows._8;
        int square64 = 0;

        for (int index = 0; index < BOARD_SQUARE_NUM; index++)
            Square120ToSquare64[index] = 65;

        for (int index = 0; index < 64; index++)
            Square64ToSquare120[index] = 120;

        for(int i = row_1; i <= row_8; i++)
        {
            for(int j = column_A; j <= column_H; j++)
            {
                int square = GetSquareCoords(i,j);
                Square64ToSquare120[square64] = square;
                Square120ToSquare64[square] = square64;
                square64++;
            }
        }
    }
    public string HelloWorld()
    {
        
        return "Hello from the engine";
    }

    public void CreateBoard()
    {
        InitSquare120To64();
    }
    public void PrintBoard()
    {
        for(int i = 0; i < BOARD_SQUARE_NUM; i++)
        {
            if(i % 10 == 0) Console.WriteLine("\n");
            Console.Write($"{Square120ToSquare64[i]}".PadLeft(2,' '));
            Console.Write(" ");
        }
        Console.Write("\n");
        Console.Write("\n");

        for(int i = 0; i < 64; i++)
        {
            if(i % 8 == 0) Console.WriteLine("\n");
            Console.Write(Square64ToSquare120[i]);
            Console.Write(" ");

        }
    }

}
