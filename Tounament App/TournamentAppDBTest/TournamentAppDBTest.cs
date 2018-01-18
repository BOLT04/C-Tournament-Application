using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TournamentAppDB;

namespace TournamentAppDBTest
{
    [TestClass]
    public class TournamentAppDBTest {

        [TestMethod]
        public void CardTest1()
        {
            //Get the items returned by the search.
            HearthstoneDBClient.Card mv = new HearthstoneDBClient().GetCards()[0];
            Assert.AreEqual("Flame Lance", mv.name);
            Assert.AreEqual(5, mv.cost);
        }

    }
}
