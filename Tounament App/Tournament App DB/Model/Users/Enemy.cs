using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TournamentAppDB.Properties;

namespace TournamentAppDB.Model.Users {
    public class Enemy : GameUser {
        public Deck Deck { get; set; } = new Deck();// This is initiated here since its redundant to put it
                                                    // in both constructors.

        public Enemy() : base() { }

        public Enemy(string name) : base(name) {
            // Auxiliary variables.
            int size = int.Parse(Resources.MAX_HAND_CARDS);
            List<Card> usedCards = new List<Card>(size);

            Card c;
            for (int i = 0; i < size; ++i) {
                do {
                    c = GetRandomCardFromDeck();
                } while (usedCards.Contains(c));

                Hand.Add(c);
                usedCards.Add(c);
            }
        }

        public Enemy(string name, Deck deck) : this(name) {
            Deck = deck;
        }

        public Card GetRandomCard() {
            Random rand = new Random();
            Card c;

            do {
                int idx = rand.Next(Hand.Count);
                c = Hand[idx];
            } while (c.Health <= 0);

            return c;
        }

        public Card GetRandomCardFromDeck() {
            Random rand = new Random();
            Card c;

            do {
                int idx = rand.Next(Deck.Count);
                c = Deck.Cards[idx];
            } while (c.Health <= 0);

            return c;
        }
    }
}
