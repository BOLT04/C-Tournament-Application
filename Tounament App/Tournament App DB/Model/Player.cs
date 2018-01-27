using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentAppDB.Model {
    public class Player {
        public string Name { get; set; }
        public List<Deck> Decks { get; set; }

        /// <summary>
        /// Used to upgrade card's stats (attributes)
        /// </summary>
        public int Points { get; set; }

        public Player() {
            Decks = new List<Deck>();
        }

        public Player(string name) : this(){
            Name = name;
        }

        public Player(string name, List<Deck> decks) {
            Name = name;
            Decks = decks;
        }
    }
}
