using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using TounamentAppUI.CustomControllers;
using TournamentAppDB.Model;
using TournamentAppDB.Model.Users;

namespace TounamentAppUI.Controller {
    public class BattleController {
        public interface OnTurnEndListener {
            void OnTurnEnd();
        }

        private Enemy enemy;
        private BattleForm battleF;

        private CardViewer currPlayerCard;

        private Action onTurnEnd;

        public BattleController(Enemy enemy, BattleForm bF) {
            this.enemy = enemy;
            battleF = bF;
            
            onTurnEnd = () => {
                IsPlayerTurn = !IsPlayerTurn;// Change turns.

                if (IsPlayerTurn)
                    StartPlayerTurn();
                else
                    StartEnemyTurn();
            };
        }

        private void StartPlayerTurn() {
            battleF.ChangeToPlayerTurn();
        }

        private void StartEnemyTurn() {
            battleF.ChangeToEnemyTurn();// Moves the turn label and sets the according text.

            Card enemyCard = enemy.GetRandomCard(battleF.GetControlsOfEnemyPanel());

            
            currPlayerCard = Player.GetRandomCard(battleF.SelectedCards);
        }

        private bool SelectedPlayerCard;
        public bool IsPlayerTurn = true;

        public void OnClickPlayerCard(CardViewerBattle cV) {
            if (!IsPlayerTurn) return;

            // If the player wants to unselect the selected card.
            if (SelectedPlayerCard && currPlayerCard.Equals(cV)) 
                Reset();
            else if (!SelectedPlayerCard) {
                currPlayerCard = cV;
                SelectedPlayerCard = true;
            }
        }

        public void OnClickEnemyCard(CardViewerEnemy enemyCard) {
            if (!SelectedPlayerCard) return;

            Battle(currPlayerCard, enemyCard);

            Reset();
            onTurnEnd();
        }

        private void Battle(CardViewer plCardView, CardViewerEnemy enCardView) {
            Card plCard = plCardView.Card;
            Card enCard = enCardView.Card;

            int newPlHP = plCard.Health - enCard.Attack;
            int newEnHP = enCard.Health - plCard.Attack;

            // Update the values of the model
            plCard.Health = newPlHP;
            enCard.Health = newEnHP;

            // Repaint both controls since their model changed.
            plCardView.Invalidate();
            enCardView.Invalidate();

            if (newPlHP <= 0) {
                // Remove card view and its model.
                battleF.GetControlsOfPlayerPanel().Remove(plCardView);
                battleF.CurrEnemy.Hand.Remove(enCard);
            }
            if (newEnHP <= 0) {
                // Remove card view and its model.
                battleF.GetControlsOfEnemyPanel().Remove(enCardView);
                battleF.SelectedCards.Remove(plCard);
            }
        }

        private void Reset() {
            currPlayerCard = null;
            SelectedPlayerCard = false;
        }

    }
}
