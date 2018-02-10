using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TournamentAppDB.Model.Tournaments;
using TournamentAppDB.Model;
using TounamentAppUI.CustomControllers;
using TournamentAppDB.Model.Users;
using TounamentAppUI.Controller;

namespace TounamentAppUI {
    public partial class BattleForm : Form {

        public static readonly int TURN_LABEL_X_POS = 351;
        public static readonly int TURN_LABEL_PLAYER_Y_POS = 283;
        public static readonly int TURN_LABEL_ENEMY_Y_POS = 110;

        public static readonly Point ENEMY_LOC =  new Point(TURN_LABEL_X_POS, TURN_LABEL_ENEMY_Y_POS);
        public static readonly Point PLAYER_LOC = new Point(TURN_LABEL_X_POS, TURN_LABEL_PLAYER_Y_POS);
        public static readonly Point CENTER_LOC =
            new Point(
                int.Parse(Properties.Resources.WINDOW_WIDTH) / 2,
                int.Parse(Properties.Resources.WINDOW_HEIGHT) / 2);

        public static readonly string TURN_LABEL_ENEMY_TEXT = "Enemy turn";
        public static readonly string TURN_LABEL_PLAYER_TEXT = "Your turn";

        public Tournament Tr { get; set; }

        public List<Card> UnSelectedCards { get; set; }

        public Enemy CurrEnemy { get; set; }

        private BattleController controller;

        private bool isTestingPlayer;
        private bool isTestingEnemy;

        public BattleForm() {
            InitializeComponent();
        }

        public BattleForm(Tournament tr, List<Card> selectedCards, List<Card> unSelectedCards) : this() {
            Tr = tr;
            Tr.Player.Hand = selectedCards;

            controller = new BattleController(this);

            turnLabel.Text = TURN_LABEL_PLAYER_TEXT;

            battleImg.ChangeImageTo(TournamentAppDB.Properties.Resources.resPath + "\\battle1_op2.png");
            playerLabel.Text = tr.Player.Name;

            InitializePlayerCardsPanel();
        }

        public BattleForm(Tournament tr, int enemyIdx, List<Card> selectedCards, List<Card> unSelectedCards)
            : this(tr, selectedCards, unSelectedCards) {
            UnSelectedCards = unSelectedCards;

            CurrEnemy = Tr.Enemies[enemyIdx];
            enemyLabel.Text = CurrEnemy.Name;

            InitializeEnemyCardsPanel();
        }

        /* Constructors intended for testing.*/
        public BattleForm(Tournament tr, int enemyIdx, List<Card> selectedCards, List<Card> unSelectedCards, bool isTestingPlayer)
            : this(tr, enemyIdx, selectedCards, unSelectedCards) {

            this.isTestingPlayer = isTestingPlayer;
            isTestingEnemy = !isTestingPlayer;
        }

        public BattleForm(Tournament tr, List<Card> selectedCards, List<Card> unSelectedCards, Enemy enemy, bool isTestingPlayer) 
            : this(tr, selectedCards, unSelectedCards) {

            this.isTestingPlayer = isTestingPlayer;
            isTestingEnemy = !isTestingPlayer;

            CurrEnemy = enemy;

            /*TODO: TAKE OUT REPEATED CODE!!*/
            enemyLabel.Text = CurrEnemy.Name;

            InitializeEnemyCardsPanel();
        }

        private void InitializePlayerCardsPanel() {
            foreach (Card c in Tr.Player.Hand) 
                playerPanel.Controls.Add(new CardViewerBattle(c, this));
        }

        private void InitializeEnemyCardsPanel() {
            foreach (Card c in CurrEnemy.Hand) 
                enemyPanel.Controls.Add(new CardViewerEnemy(c, this));
        }

        public void ChangeToPlayerTurn() {
            turnLabel.Location = PLAYER_LOC;
            turnLabel.Text = TURN_LABEL_PLAYER_TEXT;

            turnLabel.Refresh();
        }

        public void ChangeToEnemyTurn() {
            turnLabel.Location = ENEMY_LOC;
            turnLabel.Text = TURN_LABEL_ENEMY_TEXT;

            turnLabel.Refresh();
        }

        public void OnClickPlayerCard(CardViewerBattle cV) {
            controller.OnClickPlayerCard(cV);
        }

        public void OnClickEnemyCard(CardViewerEnemy cV) {
            controller.OnClickEnemyCard(cV);
        }

        public void DisplayVictory() {
            battleImg.Hide();

            // We re-use an already instantiated label, so that we don't have to create a new one just to show "Victory".
            playerLabel.Location = CENTER_LOC;
            playerLabel.BackColor = Color.DarkGreen;
            playerLabel.Font = new Font("Verdana", 20f, FontStyle.Bold);
            playerLabel.Text = "Victory";
        }

        public void DisplayDefeat() {
            battleImg.Hide();

            // We re-use an already instantiated label, so that we don't have to create a new one just to show "Victory".
            playerLabel.Location = CENTER_LOC;
            playerLabel.BackColor = Color.DarkRed;
            playerLabel.Font = new Font("Verdana", 20f, FontStyle.Bold);
            playerLabel.Text = "Defeat";
        }

        public void DisplayDraw() {
            throw new NotImplementedException();
        }

        public Control.ControlCollection GetControlsOfPlayerPanel() {
            return playerPanel.Controls;
        }

        public Control.ControlCollection GetControlsOfEnemyPanel() {
            return enemyPanel.Controls;
        }

        public bool GetIsTestingPlayer() {
            return isTestingPlayer;
        }

        public bool GetIsTestingEnemy() {
            return isTestingEnemy;
        }
    }
}
