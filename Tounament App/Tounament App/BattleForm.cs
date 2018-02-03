using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentAppDB.Model.Tournaments;

namespace TounamentAppUI {
    public partial class BattleForm : Form {
        public Tournament Tr { get; set; }

        public BattleForm() {
            InitializeComponent();
        }

        public BattleForm(Tournament tr) {
            InitializeComponent();

            Tr = tr;
        }
    }
}
