using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TounamentAppUI {
    public partial class PlayForm : Form {
        public PlayForm() {
            InitializeComponent();
        }

        private void onLevelImg1Click(object sender, EventArgs e) {
            new TournamentViewer().Show();
            Hide();
        }

        private void PlayForm_Load(object sender, EventArgs e) {

        }

        private void levelImg3_Click(object sender, EventArgs e) {

        }
    }
}
