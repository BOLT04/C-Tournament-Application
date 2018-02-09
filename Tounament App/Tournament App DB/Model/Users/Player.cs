using System;
using System.Collections.Generic;
using System.Linq;
using TournamentAppDB.Properties;

namespace TournamentAppDB.Model.Users {
    public class Player : GameUser {
        /// <summary>
        /// Used to upgrade card's stats (attributes)
        /// </summary>
        public int Points { get; set; }

        public List<Deck> Decks { get; set; } = new List<Deck> {
                new Deck(Resources.DEFAULT_DECK, Resources.resPath + "\\nature_deck_icon.png")
        };

        public Player() : base() { }

        public Player(string name)
            : base(name) { }

        public Player(string name, List<Deck> decks)
            : this(name) {
            Decks = decks;
        }

        public static Card GetRandomCard(List<Card> selectedCards) {
            throw new NotImplementedException();
        }
    }
}
