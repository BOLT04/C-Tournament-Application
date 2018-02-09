using System;
using System.Drawing;

using TournamentAppDB.Model.Users;
using TournamentAppDB.Model;
using TournamentAppDB.Model.Tournaments;
using TounamentAppUI.CustomControllers;

using System.Windows.Forms;

namespace TounamentAppUI {
    public partial class TournamentViewer : Form {

        private readonly int DECK_MAX_NUMBER = 8;// Re-allocate this to a constants interface ??
                                                 // Doesn't make much sense for the constant to be in the tournament Viewer.

        /// <summary>
        /// Gets or sets model side of this tournament viewer.
        /// </summary>
        public Tournament Tr { get; set; }

        //public BindingSource deckBinding;

        public TournamentViewer() {
            InitializeComponent();

            //deckBinding.DataSource = Tr.Player.Decks;
            //playerListView.Da = deckBinding;
        }

        public TournamentViewer(string name, Tournament tournament) : this() {
            tournamentLabel.Text = name;  // Change the text on the upper label.
            Tr = tournament;

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
            DeckViewer deckV;
            foreach (Deck deck in Tr.Player.Decks) {
                deckV = new DeckViewer(deck, this);
                playerPanel.Controls.Add(deckV);
            }
        }

        public string DeckNameSelected { get; set; }

        private void PlayBtn_Click(object sender, EventArgs e) {
            new ChoosingCardsForm(Tr, DeckNameSelected).ShowAndHide(this);
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
