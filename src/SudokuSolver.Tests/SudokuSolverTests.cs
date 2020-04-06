using System;


namespace SudokuSolver.Tests
{
    [TestFixture]
    public class SudokuSolverTests
    {
        private SudokuSolver sudokuSolver;

        [SetUp]
        public void TestInitialize()
        {
            sudokuSolver = new SudokuSolver();
        }

        [TearDown]
        public void TestCleanup()
        {
            sudokuSolver = null;
        }
        
        [Test]
        public void TestMethod1()
        {
        }
    }
}
