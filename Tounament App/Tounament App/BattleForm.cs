using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentAppDB.Model.Tournaments;
using TournamentAppDB.Model;
using TounamentAppUI.CustomControllers;
using TournamentAppDB.Model.Users;

namespace TounamentAppUI {
    public partial class BattleForm : Form {
        public Tournament Tr { get; set; }

        public List<Card> SelectedCards { get; set; }
        private Enemy currEnemy;

        public BattleForm() {
            InitializeComponent();
        }

        public BattleForm(Tournament tr, List<Card> selectedCards) {
            InitializeComponent();

            Tr = tr;
            SelectedCards = selectedCards;
            currEnemy = Tr.Enemies[0];

            InitializePlayerCardsPanel();
            InitializeEnemyCardsPanel();
        }

        private void InitializePlayerCardsPanel() {
            foreach (Card c in SelectedCards) {
                CardViewerBattle cV = new CardViewerBattle(c);
                playerPanel.Controls.Add(cV);
            }

        }

        private void InitializeEnemyCardsPanel() {
            //Auxiliary variables.
            int size = ChoosingCardsForm.MAX_SELECTED_CARDS;
            Random rand = new Random();
            List<Card> usedCards = new List<Card>(size);
            List<Card> cards = currEnemy.Deck.Cards;

            Card c;
            for (int i = 0, idx; i < size; ++i) {
                do {
                    idx = rand.Next(cards.Count);
                    c = cards.ElementAt(idx);
                } while (usedCards.Contains(c));

                usedCards.Add(c);

                CardViewerBattle cV = new CardViewerBattle(c);
                playerPanel.Controls.Add(cV);
            }
        }
    }
}
