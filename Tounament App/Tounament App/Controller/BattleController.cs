using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TounamentAppUI.CustomControllers;
using TournamentAppDB.Model;

namespace TounamentAppUI.Controller {
    public class BattleController {
        private BattleForm battleF;

        CardViewer currPlayerCard;

        public BattleController(BattleForm bF) {
            battleF = bF;
            
        }

        private bool SelectedPlayerCard;

        public void OnClickPlayerCard(CardViewerBattle cV) {
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

            if (newPlHP <= 0)
                battleF.GetControlsOfPlayerPanel().Remove(plCardView);

            if (newEnHP <= 0)
                battleF.GetControlsOfEnemyPanel().Remove(enCardView);
        }

        private void Reset() {
            currPlayerCard = null;
            SelectedPlayerCard = false;
        }

    }
}
