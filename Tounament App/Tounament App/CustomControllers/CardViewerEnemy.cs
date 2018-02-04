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
    public partial class CardViewerEnemy : CardViewer {

        private BattleForm parentForm;


        public CardViewerEnemy(): base() { }

        public CardViewerEnemy(Card c, BattleForm bF) : base(c) {
            parentForm = bF;
        }

        /// <summary>
        /// Dispatch execution of this event to the parent form.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(MouseEventArgs e) {
            parentForm.OnClickEnemyCard(this);
        }

        protected override void OnMouseEnter(EventArgs e) {
            MouseInColor = Color.Red;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e) {
            MouseInColor = Color.Transparent;
            Invalidate();
        }
    }
}
