using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using TournamentAppDB.Model;
using TournamentAppDB.Model.Tournaments;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TounamentAppUI {
    public partial class TournamentViewer : Form {

        private readonly int DECK_MAX_NUMBER = 8;// Re-allocate this to a constants interface ??
                                                 // Doesn't make much sense for the constant to be in the tournament Viewer.

        /// <summary>
        /// Model side of this tournament viewer.
        /// </summary>
        public Tournament Tr { get; set; }
        //Array that contains a reference to all deck images defined on the other part of this class.
        public PictureBox[] deckImgs;
        public Label[] deckLabels;

        public TournamentViewer(string name, Tournament tournament) {
            InitializeComponent();

            tournamentLabel.Text = name;  //Change the text on the upper label.
            Tr = tournament;

            /*Define and initialize the deckImgs and deckLabels arrays.*/
            //TODO: Maybe instead of having these two arrays, make a new class that represents one DeckViewer
            //     which has its image and label!
            deckImgs = new PictureBox[DECK_MAX_NUMBER];
            deckLabels = new Label[DECK_MAX_NUMBER];

            //TODO: Make this code better, its too hard-coded!! 
            // Maybe take out the already defined deckImg's and make your own with code as needed!
            deckImgs[0] = deckImg1;
            deckImgs[1] = deckImg2;
            deckImgs[2] = deckImg3;
            deckImgs[3] = deckImg4;
            deckImgs[4] = deckImg5;
            deckImgs[5] = deckImg6;
            deckImgs[6] = deckImg7;
            deckImgs[7] = deckImg8;

            deckLabels[0] = deck1Name;
            deckLabels[1] = deck2Name;
            deckLabels[2] = deck3Name;
            deckLabels[3] = deck4Name;
            deckLabels[4] = deck5Name;
            deckLabels[5] = deck6Name;
            deckLabels[6] = deck7Name;
            deckLabels[7] = deck8Name;

            InitializeEnemyListView();

            InitializePlayerListView();
        }


        private void InitializeEnemyListView() {
            //TODO: This code could probably get cleaner, 
            //it's not cristal clear at the first glance when it should!!
            ListViewItem[] enemies = new ListViewItem[Tr.Enemies.Count];
            int i = 0;
            foreach (Enemy e in Tr.Enemies)
                enemies[i++] = new ListViewItem(e.Name);

            enemiesListView.Items.AddRange(enemies);
        }

        private void InitializePlayerListView() {
            int i = 0;
            foreach (Deck deck in Tr.Player.Decks) {
                deckImgs[i].ChangeImageTo(deck.Path);
                deckLabels[i++].Text = deck.Name;
            }
        }

        private void playBtn_Click(object sender, EventArgs e) {
            new ChoosingCardsForm(Tr, deckNameSelected).ShowAndHide(this);
        }

        private string deckNameSelected;

        private void DeckImg1_Click(object sender, EventArgs e) {
            deckNameSelected = deck1Name.Text;
        }

        private void DeckImg2_Click(object sender, EventArgs e) {
            deckNameSelected = deck2Name.Text;
        }

        private void DeckImg3_Click(object sender, EventArgs e) {
            deckNameSelected = deck3Name.Text;
        }

        private void DeckImg4_Click(object sender, EventArgs e) {
            deckNameSelected = deck4Name.Text;
        }

        private void DeckImg5_Click(object sender, EventArgs e) {
            deckNameSelected = deck5Name.Text;
        }

        private void DeckImg6_Click(object sender, EventArgs e) {
            deckNameSelected = deck6Name.Text;
        }

        private void DeckImg7_Click(object sender, EventArgs e) {
            deckNameSelected = deck7Name.Text;
        }

        private void DeckImg8_Click(object sender, EventArgs e) {
            deckNameSelected = deck8Name.Text;
        }
    }

    public static class Extends {
        /// <summary>
        /// Open a new image with the given filename and assign it to this PictureBox instance.
        /// </summary>
        /// <param name="img">PictureBox instance that called this method</param>
        /// <param name="fileName"> The image's file name and path</param>
        public static void ChangeImageTo(this PictureBox img, string fileName) {
            img.Image = new Bitmap(fileName);
            img.Invalidate();
            img.Visible = true; //necessary??
        }

        /// <summary>
        /// Displays the caller Form and hides the other given form.
        /// </summary>
        /// <param name="f">Form to hide.</param>
        public static void ShowAndHide(this Form src, Form f) {
            src.Show();
            f.Hide();
        }
    }
}
