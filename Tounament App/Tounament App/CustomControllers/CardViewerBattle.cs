﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

using System.Drawing;
using TounamentAppUI;
using System.Windows.Forms;
using TournamentAppDB.Model;

namespace TounamentAppUI.CustomControllers {
    public partial class CardViewerBattle : CardViewer {
        private BattleForm parentForm;


        public CardViewerBattle()
            : base() { }

        public CardViewerBattle(Card c, BattleForm bF) : base(c) {
            parentForm = bF;
        } 
        
        /// <summary>
        /// Dispatch execution of this event to the parent form.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(MouseEventArgs e) {
            parentForm.OnClickPlayerCard(this);
        }
    }
}
