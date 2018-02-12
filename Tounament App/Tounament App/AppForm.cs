using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentAppDB.Model;

namespace TounamentAppUI {
    public partial class AppForm : Form {

        

        public Game game;//TODO: should this field exist in this class? Or in App.cs?

        public AppForm() {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e) {

        }

        private void PlayBtn_Click(object sender, EventArgs e) {
            if (game == null)// In case it was already instanciated.
                game = new Game();
            //game.start();

            new PlayForm().ShowAndHide(this);
        }

        private void EditCharacter_Click(object sender, EventArgs e) {
            
        }
    }
}
