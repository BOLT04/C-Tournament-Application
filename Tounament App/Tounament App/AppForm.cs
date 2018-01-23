using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentAppDB.Model;

namespace TounamentAppUI
{
    public partial class AppForm : Form {
        public Game game;//TODO: should this field exist in this class? Or in App.cs?

        public AppForm() {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e) {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void playBtn_Click(object sender, EventArgs e) {
            if (game == null)// In case it was already instanciated.
                game = new Game();
            //game.start();

            //Show the new window and hide the current one.
            //TODO:
            //Extract this code to an extension method of Form called ShowAndHideCurr() => new PlayForm().ShowAndHideCurr(this)
            new PlayForm().Show();
            Hide();
        }

        private void editCharacter_Click(object sender, EventArgs e) {
            
        }
    }
}
