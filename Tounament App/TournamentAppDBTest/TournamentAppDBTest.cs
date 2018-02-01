using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TournamentAppDB;
using TournamentAppDB.Model;

namespace TournamentAppDBTest{

    [TestClass]
    public class TournamentAppDBTest {

        private HearthstoneDBClient hDBClient = new HearthstoneDBClient();

        [TestMethod]
        public void SingleSpellCardTest() {
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
            Card card = hDBClient.GetCard(expectedName, expectedId);

            Assert.AreEqual(expectedCardClass, card.CardClass);
            Assert.AreEqual(expectedCost,      card.Cost);
            Assert.AreEqual(expectedFlavor,    card.Flavor);
            Assert.AreEqual(expectedRarity,    card.Rarity);
            Assert.AreEqual(expectedText,      card.Text);
            Assert.AreEqual(expectedType,      card.Type);
            
            //Since this card is a spell, these properties have the default value.
            Assert.AreEqual(null, card.Mechanics);
            Assert.AreEqual(0, card.Health);
            Assert.AreEqual(0, card.Attack);
        }

        [TestMethod]
        public void SingleMinionCardTest() {
            //Auxiliary constants.
            const int expectedATK = 4;
            const string expectedCardClass = "NEUTRAL";
            const int expectedCost = 3;
            const int expectedHP = 2;
            const string expectedId = "AT_005t";
            string[] expectedMechanics = new string[] {"CHARGE"};
            const string expectedName = "Boar";
            const string expectedRace = "BEAST";
            const string expectedText = "<b>Charge</b>";
            const string expectedType = "MINION";

            //Get the items returned by the search.
            Card card = hDBClient.GetCard(expectedName, expectedId);

            Assert.AreEqual(expectedATK, card.Attack);
            Assert.AreEqual(expectedCardClass, card.CardClass);
            Assert.AreEqual(expectedCost, card.Cost);
            Assert.AreEqual(expectedHP, card.Health);
            Assert.IsTrue(expectedMechanics.SequenceEqual(card.Mechanics));
            Assert.AreEqual(expectedRace, card.Race);
            Assert.AreEqual(expectedText, card.Text);
            Assert.AreEqual(expectedType, card.Type);

            //Since this card is a spell, these properties have the default value.
            Assert.AreEqual(null, card.Rarity);
        }

    }
}
