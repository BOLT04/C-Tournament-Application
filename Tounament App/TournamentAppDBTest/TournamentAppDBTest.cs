using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TournamentAppDB;
using TournamentAppDB.Model;

namespace TournamentAppDBTest{

    [TestClass]
    public class TournamentAppDBTest {

        private HearthstoneDBClient hDBClient = new HearthstoneDBClient();

        [TestMethod]
        public void SingleCardTest() {
            //Auxiliary constants.
            const string expectedName = "Flame Lance";
            const string expectedCardClass = "MAGE";
            const int expectedCost = 5;
            const string expectedFlavor = "It's on the rack next to ice lance, acid lance, and English muffin lance.";
            const string expectedId = "AT_001";
            const string expectedRarity = "COMMON";
            const string expectedText = "Deal $8 damage to a minion.";
            const string expectedType = "SPELL";

            //Get the items returned by the search.
            Card card = hDBClient.GetCard(expectedName);

            if (card == null)// Then it means there is no card associated with that name key.
                throw new ArgumentException("There is no card in the database with the name: " + expectedName);

            Assert.AreEqual(expectedCardClass, card.CardClass);
            Assert.AreEqual(expectedCost,      card.Cost);
            Assert.AreEqual(expectedFlavor,    card.Flavor);
            Assert.AreEqual(expectedId,        card.Id);
            Assert.AreEqual(expectedRarity,    card.Rarity);
            Assert.AreEqual(expectedText,      card.Text);
            Assert.AreEqual(expectedType,      card.Type);
            
            //Since this card is a spell, these properties have the default value.
            Assert.AreEqual(null, card.Mechanics);
            Assert.AreEqual(0, card.Health);
            Assert.AreEqual(0, card.Attack);
        }


    }
}
