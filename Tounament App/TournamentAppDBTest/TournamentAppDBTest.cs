using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TournamentAppDB;

namespace TournamentAppDBTest{
    [TestClass]
    public class TournamentAppDBTest {

        [TestMethod]
        public void SingleCardTest() {
            //Get the items returned by the search.
            HearthstoneDBClient.Card card = new HearthstoneDBClient().GetCard("Flame Lance");
            Assert.AreEqual(5, card.cost);
        }


    }
}
