namespace Chess.Engine;

public static class Bitboard
{
    private static readonly int[] BitTable =
    [
        63, 30, 3, 32, 25, 41, 22, 33,
        15, 50, 42, 13, 11, 53, 19, 34,
        61, 29, 2, 51, 21, 43, 45, 10,
        18, 47, 1, 54, 9, 57, 0, 35,
        62, 31, 40, 4, 49, 5, 52, 26,
        60, 6, 23, 44, 46, 27, 56, 16,
        7, 39, 48, 24, 59, 14, 12, 55,
        38, 28, 58, 20, 37, 17, 36, 8
    ];
    /// <summary>
    /// Finds and removes the least significant set bit from the bitboard,
    /// returning its position (0-63).
    /// </summary>
    public static int PopBit(ref ulong bitboard)
    {
        // Create a mask from bit 0 through the least significant set bit.
        ulong b = bitboard ^ (bitboard - 1);
        // Fold the 64-bit mask into 32 bits.
        uint fold = (uint)((b & 0xffffffff) ^ (b >> 32));
        // Remove the least significant set bit.
        bitboard &= bitboard - 1;
        // Convert the folded value into the position of the removed bit.
        return BitTable[(fold * 0x783a9b23) >> 26];
    }   
    /// <summary>
    /// Counts the number of set bits (1s) in a bitboard.
    /// This is also known as the population count (popcount).
    /// </summary>
    public static int CountBits(ulong bitboard)
    {
        int count = 0;
        // Continue until there are no set bits left.
        while (bitboard != 0)
        {
            // Clear the least significant set bit.
            // Example: 10110000 -> 10100000
            bitboard &= bitboard - 1;
            count++;
        }

        return count;
    }

}