using System.Collections.Generic;
using TournamentAppDB.Model.Users;

namespace TournamentAppDB.Model.Tournaments {
    public abstract class Tournament {
        public string Name { get; set; }
        public List<Enemy> Enemies { get; set; }
        public Player Player { get; set; }
        public int timesPlayed;
        public List<Card> prizes; // If list.Len == 0 => the prize are Points that are used to upgrade cards.
    }
}