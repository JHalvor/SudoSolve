using SudoSolve.console;

string input = "";
bool validInput = false;
int boardSize = 3;

Console.Write("How big do you want the board to be? ");

do
{
    input = Console.ReadLine();
    validInput = int.TryParse(input, out boardSize);
}
while (!validInput);

Board board = new Board(boardSize);
Console.WriteLine(board.PrintBoard());
