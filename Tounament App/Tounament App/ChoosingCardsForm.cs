﻿using System;
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
using TounamentAppUI.CustomControllers;
using System.Windows.Forms;

namespace TounamentAppUI {
    public partial class ChoosingCardsForm : Form {
        public static readonly int MAX_SELECTED_CARDS = 4;

        public Tournament Tr { get; set; }
        // Deck selected.
        private Deck selDeck;

        public List<Card> SelectedCards { get; set; }
        public List<Card> UnSelectedCards { get; set; } 

        public ChoosingCardsForm() {
            InitializeComponent();

            SelectedCards = new List<Card>(MAX_SELECTED_CARDS);
        }

        public ChoosingCardsForm(Tournament tr, string deckName) : this() {
            Tr = tr;

            selDeck = Tr.Player.Decks.Find(d => d.Name.Equals(deckName));

            UnSelectedCards = new List<Card>(selDeck.Count - MAX_SELECTED_CARDS);

            InitializeCardsPanel();
        }

        /// <summary>
        /// Fill the cardsPanel with all cards inside the choosen deck.
        /// </summary>
        private void InitializeCardsPanel() {
            foreach (Card c in selDeck.Cards) {
                CardViewerChoosing cV = new CardViewerChoosing(c, this);
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
                new BattleForm(Tr, 0, SelectedCards, UnSelectedCards).ShowAndHide(this);
        }
    }
}
