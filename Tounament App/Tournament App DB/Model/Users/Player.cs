using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentAppDB.Model.Users {
    public class Player : GameUser {
        /// <summary>
        /// Used to upgrade card's stats (attributes)
        /// </summary>
        public int Points { get; set; }

        public Player() : base() { }

        public Player(string name) : base(name) { }

        public Player(string name, List<Deck> decks) : this(name) {
            Decks = decks;
        }
    }
}
