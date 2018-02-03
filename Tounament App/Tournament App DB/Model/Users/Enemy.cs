using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentAppDB.Model.Users {
    public class Enemy : GameUser{
       
        public Enemy() : base() { }

        public Enemy(string name) : base(name) { }

        public Enemy(string name, List<Deck> decks) : this(name) {
            Decks = decks;
        }
    }
}
