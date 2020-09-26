using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EggDrop;

namespace EggProblemUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AssertionTests()
        {
            //assert edge cases

            DropGame game = new DropGame(100, 100);
            Assert.AreEqual(game.FindHighestLevel(), 99);

            game.setBreaksOnLevel(1);
            Assert.AreEqual(game.FindHighestLevel(), 0);

            game.setBreaksOnLevel(11);
            Assert.AreEqual(game.FindHighestLevel(), 10);

            game.setBreaksOnLevel(99);
            Assert.AreEqual(game.FindHighestLevel(), 98);
        }
    }
}
