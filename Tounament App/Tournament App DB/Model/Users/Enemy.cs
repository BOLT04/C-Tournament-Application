using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TournamentAppDB.Properties;

namespace TournamentAppDB.Model.Users {
    public class Enemy : GameUser{
        public Deck Deck { get; set; } = new Deck();// This is initiated here since its redundant to put it
                                                    // in both constructors.

        /// <summary>
        /// Represents the cards on the hand of the enemy.
        /// </summary>
        public List<Card> Hand { get; set; }

        public Enemy() { }

        public Enemy(string name) : base(name) {
            // Auxiliary variables.
            int size = int.Parse(Resources.MAX_HAND_CARDS);
            List<Card> usedCards = new List<Card>(size);

            Card c;
            for (int i = 0; i < size; ++i) {
                do {
                    c = GetRandomCard();
                } while (usedCards.Contains(c));
                
                Hand.Add(c);
                usedCards.Add(c);
            }
        }

        public Enemy(string name, Deck deck) : this(name) {
            Deck = deck;
        }

        public CardViewer GetRandomCard(Control.ControlCollection cardsCollection) {
            Random rand = new Random();
            Card c;
            do {
                int idx = rand.Next(cardsCollection.Count);
                c = cardsCollection[idx];
            } while (c.Health <= 0);

            return c;
        }

    }
}
