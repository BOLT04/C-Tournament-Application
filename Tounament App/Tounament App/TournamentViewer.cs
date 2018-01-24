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

        //Model side of this tournament viewer.
        private Tournament tournament;

        public TournamentViewer(string name, Tournament tournament) {
            InitializeComponent();

            tournamentLabel.Text = name;  //Change the text on the upper label.
            this.tournament = tournament;

            InitializeEnemyListView();
        }


       

        private void InitializeEnemyListView() {
            ListViewItem[] enemies = new ListViewItem[tournament.Enemies.Count];
            int i = 0;
            foreach (Enemy e in tournament.Enemies)
                enemies[i++] = new ListViewItem(e.Name);

            enemiesListView.Items.AddRange(enemies);
        }
    }
}
