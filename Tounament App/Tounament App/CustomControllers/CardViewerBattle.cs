using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

using System.Drawing;

using System.Windows.Forms;
using TournamentAppDB.Model;

namespace TounamentAppUI.CustomControllers {
    public partial class CardViewerBattle : CardViewer {

        public CardViewerBattle() : base() { }

        public CardViewerBattle(Card c) : base(c) { } 
        
        protected override void OnMouseClick(MouseEventArgs e) {
            
        }
    }
}
