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
using TournamentAppDB.Model;
using TounamentAppUI.CustomControllers;
using TournamentAppDB.Model.Users;
using TounamentAppUI.Controller;
using TournamentAppDB.Properties;

namespace TounamentAppUI {
    public partial class BattleForm : Form {

        public static readonly int TURN_LABEL_X_POS = 351;
        public static readonly int TURN_LABEL_PLAYER_Y_POS = 283;
        public static readonly int TURN_LABEL_ENEMY_Y_POS = 110;

        public static readonly string TURN_LABEL_ENEMY_TEXT = "Enemy turn";
        public static readonly string TURN_LABEL_PLAYER_TEXT = "Your turn";

        public Tournament Tr { get; set; }

        public List<Card> SelectedCards { get; set; }
        public List<Card> UnSelectedCards { get; set; }

        public Enemy CurrEnemy { get; set; }

        private BattleController controller;

        public BattleForm() {
            InitializeComponent();

            controller = new BattleController(CurrEnemy, this);
        }

        public BattleForm(Tournament tr, List<Card> selectedCards, List<Card> unSelectedCards) : this() {
            Tr = tr;
            SelectedCards = selectedCards;
            UnSelectedCards = unSelectedCards;

            CurrEnemy = Tr.Enemies[0];

            turnLabel.Text = TURN_LABEL_PLAYER_TEXT;

            battleImg.ChangeImageTo(Resources.resPath + "\\battle1_op2.png");
            playerLabel.Text = tr.Player.Name;
            enemyLabel.Text = CurrEnemy.Name;

            InitializePlayerCardsPanel();
            InitializeEnemyCardsPanel();
        }

        private void InitializePlayerCardsPanel() {
            foreach (Card c in SelectedCards) 
                playerPanel.Controls.Add(new CardViewerBattle(c, this));
        }

        private void InitializeEnemyCardsPanel() {
            // Auxiliary variables.
            /*int size = ChoosingCardsForm.MAX_SELECTED_CARDS;
            Random rand = new Random();
            List<Card> usedCards = new List<Card>(size);
            List<Card> cards = CurrEnemy.Deck.Cards;

            Card c;
            for (int i = 0, idx; i < size; ++i) {
                do {
                    idx = rand.Next(cards.Count);
                    c = cards.ElementAt(idx);
                } while (usedCards.Contains(c));

                usedCards.Add(c);

                CardViewerEnemy cV = new CardViewerEnemy(c, this);
                enemyPanel.Controls.Add(cV);
                
            }*/

            foreach (Card c in CurrEnemy.Hand) 
                enemyPanel.Controls.Add(new CardViewerEnemy(c, this));
        }

        public void ChangeToPlayerTurn() {
            turnLabel.Location = new Point(TURN_LABEL_X_POS, TURN_LABEL_PLAYER_Y_POS);
            turnLabel.Text = TURN_LABEL_PLAYER_TEXT;
        }

        public void ChangeToEnemyTurn() {
            turnLabel.Location = new Point(TURN_LABEL_X_POS, TURN_LABEL_ENEMY_Y_POS);
            turnLabel.Text = TURN_LABEL_ENEMY_TEXT;
        }

        public void OnClickPlayerCard(CardViewerBattle cV) {
            controller.OnClickPlayerCard(cV);
        }

        public void OnClickEnemyCard(CardViewerEnemy cV) {
            controller.OnClickEnemyCard(cV);
        }

        public Control.ControlCollection GetControlsOfPlayerPanel() {
            return playerPanel.Controls;
        }

        public Control.ControlCollection GetControlsOfEnemyPanel() {
            return enemyPanel.Controls;
        }
    }
}
