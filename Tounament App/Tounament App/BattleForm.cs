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

namespace TounamentAppUI {
    public partial class BattleForm : Form {
        public Tournament Tr { get; set; }

        public List<Card> SelectedCards { get; set; }

        public BattleForm() {
            InitializeComponent();
        }

        public BattleForm(Tournament tr, List<Card> selectedCards) {
            InitializeComponent();

            Tr = tr;
            SelectedCards = selectedCards;

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
        }
    }
}
