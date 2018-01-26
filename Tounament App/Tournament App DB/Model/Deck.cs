using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentAppDB.Model {
    public class Deck {
        public List<Card> Cards { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public Deck() {
            Cards = new List<Card>();
        }

        public Deck(string name, string path) : this() {
            Name = name;
            Path = path;
        }
    }
}
