using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentAppDB.Model.Tournaments;
using TournamentAppDB.Model;
using System.Windows.Forms;

namespace TounamentAppUI {
    public partial class ChoosingCardsForm : Form {
        public static readonly int MAX_SELECTED_CARDS = 4;

        public Tournament Tr { get; set; }
        //Name of deck selected.
        private string deckName = Properties.Resources.defaultStr;

        //public int SelectedCards { get; set; }
        public List<Card> SelectedCards { get; set; } = new List<Card>(MAX_SELECTED_CARDS);

        public ChoosingCardsForm() {
            InitializeComponent();
        }

        public ChoosingCardsForm(Tournament tr, string deckName) : this(){
            Tr = tr;
            this.deckName = deckName;

            InitializeCardsPanel();
        }

        /// <summary>
        /// Fill the cardsPanel with all cards inside the choosen deck.
        /// </summary>
        private void InitializeCardsPanel() {
            Deck selDeck = Tr.Player.Decks.Find(d => d.Name.Equals(deckName));

            foreach (Card c in selDeck.Cards) {
                CardViewer cV = new CardViewer(c, this);
                cardsPanel.Controls.Add(cV);
            }
        }

        private void ChoosingCardsForm_Load(object sender, EventArgs e) {

        }

        private void cardViewer1_Click(object sender, EventArgs e) {

        }

        private void Button1_Click(object sender, EventArgs e) {
            if (SelectedCards.Count != MAX_SELECTED_CARDS)
                MessageBox.Show("Please select " +MAX_SELECTED_CARDS+ " cards before continuing", "Error", MessageBoxButtons.OK,               MessageBoxIcon.Information);
            else
                new BattleForm(Tr).ShowAndHide(this);
        }
    }
}
