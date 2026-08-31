using Chess.Engine;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ChessEngine>();
var app = builder.Build();

app.Map("/engine", () =>
{
      int d2 = BoardMapping.To64((int)Squares.D2);
      int d3 = BoardMapping.To64((int)Squares.D3);
      int d4 = BoardMapping.To64((int)Squares.D4);

      ulong bitboard = 0UL;

      // bitboard |= 1UL << d2;
      // bitboard |= 1UL << d3;
      // bitboard |= 1UL << d4;

      Bitboard.SetBit(ref bitboard,d2);
      Bitboard.RemoveBit(ref bitboard,d2);
      BoardPrinter.PrintBoard();
      Console.Write("\n");
      Console.Write("\n");
      Console.Write("\n");
      BoardPrinter.PrintBitboard(bitboard);
      Bitboard.PopBit(ref bitboard);
    
});
app.Run();
