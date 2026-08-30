namespace Chess.Engine;

public class Bitboards
{
    private ChessEngine _engine; 
    Bitboards(ChessEngine engine)
    {
        _engine = engine; 
    }
    void PrintBitBoard(ulong bitboard)
    {
        ulong shiftMe = 1UL; 
        int row_1 = (int)Rows._1; 
        int row_8 = (int)Rows._8; 
        int column_A = (int)Columns.A; 
        int column_H = (int)Columns.H; 

        for(int row = row_8; row >= row_1; row--)
        {
            for(int column = column_A; column <= column_H; column++)
            {
                int square = _engine.GetSquareCoords(row, column); //120 base index
                int square64 = _engine.Square64(square); //64 base index
                
                if(((shiftMe << square64) & bitboard) != 0)
                {
                    Console.Write("X");
                } else
                {
                    Console.Write("-");
                }
            }
            Console.Write("\n");
        }
        Console.Write("\n\n");

    }
}