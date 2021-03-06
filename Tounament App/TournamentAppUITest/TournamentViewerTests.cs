﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TounamentAppUI;
using TournamentAppDB.Model;
using TournamentAppDB.Model.Tournaments;
using TournamentAppDB.Properties;

namespace TournamentAppUITest {

    public partial class TournamentViewerTests : Form {
        public TournamentViewerTests() {
            InitializeComponent();
        }

        public static Deck deck1 = new Deck("First deck", Resources.resPath + "\\nature_deck_icon.png");
        public static Deck deck2 = new Deck("Second deck", Resources.resPath + "\\nature_deck_icon.png");
        public static Deck deck3 = new Deck("Awesome deck", Resources.resPath + "\\light_deck_icon.png");

        private void TestBtn1_Click(object sender, EventArgs e) {
            List<Deck> decks = new List<Deck> {
                deck1
            };

            Tournament tr = new Tournament1("Test Player 1", decks);
            TournamentViewer trV = new TournamentViewer("Test Tournament 1", tr);
           
            trV.Show();
        }

        private void TestBtn2_Click(object sender, EventArgs e) {
            List<Deck> decks = new List<Deck> {
                deck1,
                deck2
            };

            Tournament tr = new Tournament1("Test Player 2", decks);
            TournamentViewer trV = new TournamentViewer("Test Tournament 2", tr);

            trV.Show();
        }

        private void TestBtn3_Click(object sender, EventArgs e) {
            List<Deck> decks = new List<Deck> {
                deck1,
                deck2,
                deck3
            };

            Tournament tr = new Tournament1("Test Player 3", decks);
            TournamentViewer trV = new TournamentViewer("Test Tournament 3", tr);

            trV.Show();
        }
    }
}
