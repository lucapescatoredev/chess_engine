using System.ComponentModel;

namespace Chess.Engine;
    public enum Columns
    {
        A, B, C, D, E, F, G, H, NONE
    }
    public enum Rows
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
    public enum Squares
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
    enum Colors
    {
        WHITE, BLACK, BOTH
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
    public class ChessEngine
    {
    }
