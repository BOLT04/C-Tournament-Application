using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using TounamentAppUI.CustomControllers;
using TournamentAppDB.Model;
using TournamentAppDB.Model.Users;

namespace TounamentAppUI.Controller {
    public class BattleController {
        public interface OnTurnEndListener {
            void OnTurnEnd();
        }

        private BattleForm battleF;

        private CardViewer currPlayerCard;

        private Action onTurnEnd;

        public BattleController(BattleForm bF) {
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

            Thread.Sleep(2000); // Give a little delay before choosing random cards.

            CardViewer enemyRandCard = GetRandomEnemyCard();
            currPlayerCard = GetRandomPlayerCard();

            Battle(currPlayerCard, enemyRandCard);

            ResetAndNotifyDelegate();
        }

        private static Random rand = new Random();

        private CardViewer GetRandomPlayerCard() {
            // Get the controls that represent the enemy's hand.
            Control.ControlCollection handV = battleF.GetControlsOfPlayerPanel();
            CardViewer cV;

            do {
                int idx = rand.Next(battleF.Tr.Player.Hand.Count);
                cV = (CardViewer)handV[idx];
            } while (cV.Card.Health <= 0);

            return cV;
        }

        private CardViewer GetRandomEnemyCard() {
            // Get the controls that represent the enemy's hand.
            Control.ControlCollection handV = battleF.GetControlsOfEnemyPanel();
            CardViewer cV;

            do {
                int idx = rand.Next(battleF.CurrEnemy.Hand.Count);
                cV = (CardViewer) handV[idx];
            } while (cV.Card.Health <= 0);

            return cV;
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

            ResetAndNotifyDelegate();
        }

        private void Battle(CardViewer plCardView, CardViewer enCardView) {
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

            /* Remove card view and its model if the cards are below than zero.*/
            if (newPlHP <= 0) {
                battleF.GetControlsOfPlayerPanel().Remove(plCardView);
                battleF.Tr.Player.Hand.Remove(plCard);
            }

            if (newEnHP <= 0) {
                battleF.GetControlsOfEnemyPanel().Remove(enCardView);
                battleF.CurrEnemy.Hand.Remove(enCard);
            }
        }

        private void Reset() {
            currPlayerCard = null;
            SelectedPlayerCard = false;
        }

        private void ResetAndNotifyDelegate() {
            Reset();
            onTurnEnd();
        }

    }
}
