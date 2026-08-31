namespace Chess.Engine;
public static class BoardMapping
{   
    private static readonly int[] From120To64;
    private static readonly int[] From64To120;
    static BoardMapping()
    {
        From120To64 = Create120To64();
        From64To120 = Create64To120();
    }
    private const int OFFBOARD_64 = 65; 
    private const int OFFBOARD_120 = 120;

    private static int[] Create120To64()
    {
        int[] mapping = new int[120];
        Array.Fill(mapping, OFFBOARD_64);
        for(int square64 = 0; square64 < 64; square64++)
        {
            int row = square64 / 8;
            int column = square64 % 8; 
            int square120 = 21 + column + row * 10; 
            mapping[square120] = square64;
        }
        return mapping;
    }
    private static int[] Create64To120()
    {
        int[] mapping = new int[64];
        for(int square64 = 0; square64 < 64; square64++)
        {
            int row = square64 / 8; 
            int column = square64 % 8; 
            mapping[square64] = 21 + column + row * 10;
        }
        return mapping;
    }

    public static int To64(int square120) => From120To64[square120];
    public static int To120(int square64) => From64To120[square64];
    public static ulong SetBit(ref ulong bitboard, int square) =>  bitboard |= 1UL << square;
    public static ulong RemoveBit(ref ulong bitboard, int square) => bitboard &= ~(1UL << square);

}