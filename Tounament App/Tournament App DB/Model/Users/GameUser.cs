using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentAppDB.Properties;

namespace TournamentAppDB.Model.Users {
    public class GameUser {
        public string Name { get; set; }
        public List<Deck> Decks { get; set; }

        public GameUser() {
            Decks = new List<Deck> {
                new Deck("Default deck", Resources.resPath + "\\nature_deck_icon.png")
            };
        }

        public GameUser(string name) : this() {
            Name = name;
        }
    }
}
