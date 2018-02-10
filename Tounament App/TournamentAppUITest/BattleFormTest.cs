using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TounamentAppUI;
using TournamentAppDB.Model;
using TournamentAppDB.Model.Users;
using TournamentAppDB.Model.Tournaments;

namespace TournamentAppUITest {
    public partial class BattleFormTest : Form {
        public BattleFormTest() {
            InitializeComponent();
        }

        private void TestEnemyTurn_Click(object sender, EventArgs e) {
            List<Deck> decks = new List<Deck> {
                TournamentViewerTests.deck1
            };

            Tournament tr = new Tournament1("Test Player 1", decks);

            Enemy enemy = new Enemy("Test Enemy 1", decks[0]);

            Deck auxDeck = decks[0];

            auxDeck.Cards[0].Health = 20;
            auxDeck.Cards[1].Health = 20;
            auxDeck.Cards[2].Health = 20;
            auxDeck.Cards[3].Health = 20;

            List<Card> selectedCards = new List<Card>() {
                auxDeck.Cards[0],
                auxDeck.Cards[1],
                auxDeck.Cards[2],
                auxDeck.Cards[3],
            };

            BattleForm battleF = new BattleForm(tr, selectedCards, new List<Card>(), enemy, false);

            battleF.Show();
        }

        private void TestPlayerTurn_Click(object sender, EventArgs e) {
            List<Deck> decks = new List<Deck> {
                TournamentViewerTests.deck1
            };

            Tournament tr = new Tournament1("Test Player 1", decks);

            Deck auxDeck = decks[0];

            auxDeck.Cards[0].Health = 20;
            auxDeck.Cards[1].Health = 20;
            auxDeck.Cards[2].Health = 20;
            auxDeck.Cards[3].Health = 20;

            List<Card> selectedCards = new List<Card>() {
                auxDeck.Cards[0],
                auxDeck.Cards[1],
                auxDeck.Cards[2],
                auxDeck.Cards[3],
            };

            BattleForm battleF = new BattleForm(tr, 0, selectedCards, new List<Card>(), true);

            battleF.Show();
        }
    }
}
