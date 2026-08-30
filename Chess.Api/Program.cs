using Chess.Engine;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ChessEngine>();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.Map("/engine", () =>
{
      int d2 = SquareMapping.To64((int)Squares.D2);
      int d3 = SquareMapping.To64((int)Squares.D3);
      int d4 = SquareMapping.To64((int)Squares.D4);

      ulong bitboard = 0UL;
      bitboard |= 1UL << d2;
      bitboard |= 1UL << d3;
      bitboard |= 1UL << d4;

      BoardPrinter.PrintBoard();
      Console.Write("\n");
      Console.Write("\n");
      Console.Write("\n");
      BoardPrinter.PrintBitboard(bitboard);
      Bitboard.PopBit(ref bitboard);
    
});
app.Run();
