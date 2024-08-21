namespace SudoSolve.tests;
using SudoSolve.console;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestBoardPrint()
    {
        Board board = new Board(3);
        string result = board.PrintBoard();

        Assert.That(result, Is.Not.Empty);
    }
}