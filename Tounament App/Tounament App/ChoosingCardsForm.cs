using System;
using System.Collections.Generic;
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

        public Tournament Tr { get; set; }
        //Name of deck selected.
        private string deckName = Properties.Resources.defaultStr;

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

            /*foreach (Card c in selDeck.Cards)
                cardsPanel.Controls.Add()*/
        }

        private void ChoosingCardsForm_Load(object sender, EventArgs e) {

        }
    }
}
