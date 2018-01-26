using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TounamentAppUI;
using TournamentAppDB.Properties;
using TournamentAppDB.Model;
using TournamentAppDB.Model.Tournaments;

namespace TournamentAppUITest {
    [TestClass]
    public class TournamentViewerTest {

        private static Deck deck1 = new Deck("First deck", Resources.resPath + "\\card_nature icon.png");
        private static Deck deck2 = new Deck("Secong deck", Resources.resPath + "\\card_nature icon.png");
        private static Deck deck3 = new Deck("Awesome deck", Resources.resPath + "\\card_nature icon.png");
        private static Deck wrongDeckName = new Deck("Name exceeds Max deck", 
            Resources.resPath + "\\card_nature icon.png");

        [TestMethod]
        public void PlayerWith1DeckTest() {
            TournamentViewer trV = new TournamentViewer("Test Tournament 1", new Tournament1("Player 1"));
            trV.Show();
            

            Tournament tr = trV.Tr;
            tr.Player.Decks.Add(deck1);

            Console.WriteLine();
        }

        [TestMethod]
        public void PlayerWith2DecksTest() {
            TournamentViewer trV = new TournamentViewer("Test Tournament 2", new Tournament1("Player 1"));
            trV.Show();
            trV.Visible = true;

            Tournament tr = trV.Tr;
            tr.Player.Decks.Add(deck1);
            tr.Player.Decks.Add(deck2);

            trV.Invalidate();
            trV.FormClosing += TrV_FormClosing;
            
            
        }

        private void TrV_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e) {
            Console.WriteLine();
        }
    }
}
