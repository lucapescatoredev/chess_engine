using Chess.Engine;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ChessEngine>();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.Map("/engine", (ChessEngine engine) =>
{
    engine.CreateBoard();
    engine.PrintBoard();
    Console.Write("\n");
    Console.WriteLine("----------------------------------------------------------");
    ulong bitboard = 0UL;
    int D2 = engine.Square64((int)Squares.D2);
    bitboard |= 1UL << D2; //placing a pawn on D2
    
    Console.WriteLine("D2 ADDED");
    engine.PrintBitboard(bitboard);

    int G2 = engine.Square64((int)Squares.G2);
    bitboard |= 1UL << G2;

    Console.WriteLine("G2 ADDED");
    engine.PrintBitboard(bitboard);
    
});
app.Run();
