namespace Chess.Engine;
public static class BoardPrinter {
    public static void PrintBoard()
    {
        for(int i = 0; i < Board.BOARD_SQUARE_NUM; i++)
        {
            if(i % 10 == 0) Console.WriteLine("\n");
            Console.Write($"{SquareMapping.To64(i)}".PadLeft(2,' '));
            Console.Write(" ");
        }
        Console.Write("\n");
        Console.Write("\n");

        for(int i = 0; i < 64; i++)
        {
            if(i % 8 == 0) Console.WriteLine("\n");
            Console.Write(SquareMapping.To120(i));
            Console.Write(" ");
        }
    }
    public static void PrintBitboard(ulong bitboard)
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
                int square120 = 21 + column + row * 10; //120 base index
                int square64 = SquareMapping.To64(square120); //64 base index
                
                if((bitboard & (shiftMe << square64)) != 0)
                    Console.Write("X ");
                 else
                    Console.Write("- ");
            }
            Console.Write("\n");
        }
        Console.Write("\n\n");
    }
}
