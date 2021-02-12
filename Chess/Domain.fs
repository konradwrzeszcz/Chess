namespace Chess

module Domain = 

    type Player = Light | Dark
    type ChessmanType = Pawn | Queen | King | Bishop | Knight | Rook
    type Chessman = Player * ChessmanType
    
    type Column = A | B | C | D | E | F | G | H
    type Row = One | Two | Three | Four | Five | Six | Seven | Eight
    type Position = Column * Row
    type SquareState = Taken of Chessman | Empty
    type Square = Position * SquareState

    type OriginSquare = OriginSquare of Square
    type DestinationSquare = DestinationSquare of Square
    type ChessmanMove = Chessman * OriginSquare * DestinationSquare

    type Board = Square list
    type LastChessmanMove = LastChessmanMove of ChessmanMove
    type PlayerAvailableMoves = Player * ChessmanMove list
    
    type GameState = Board * LastChessmanMove * PlayerAvailableMoves list
    
    type MoveResult =
        | NextPlayerMove of PlayerAvailableMoves
        | GameWon of Player
        | GameTied
    
    type Move = Player * ChessmanMove * GameState -> MoveResult * GameState 