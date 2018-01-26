using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentAppDB.Model.Tournaments;
using System.Windows.Forms;

namespace TounamentAppUI {
    public partial class PlayForm : Form {
        public PlayForm() {
            InitializeComponent();
        }

        private void PlayForm_Load(object sender, EventArgs e) {

        }


        private void OnLevelImg1Click(object sender, EventArgs e) {
            //Since level 1 is always unlocked we don't need to check any property.
            new TournamentViewer("Tournament 1", new Tournament1("Player 1")).Show();
            Hide();
        }

        private void OnLevelImg2Click(object sender, EventArgs e) {
            if (Tournament2.Locked) return;

            new TournamentViewer("Tournament 2", new Tournament2()).Show();
            Hide();
        }

        private void OnLevelImg3Click(object sender, EventArgs e) {

        }

        private void OnLevelImg4Click(object sender, EventArgs e) {

        }

        private void OnLevelImg5Click(object sender, EventArgs e) {

        }
    }
}
