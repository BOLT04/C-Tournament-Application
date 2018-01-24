using System.Collections.Generic;

namespace TournamentAppDB.Model.Tournaments {
    public abstract class Tournament {
        public string Name { get; set; }
        public List<Enemy> Enemies { get; set; }
        private int timesPlayed;
        private List<Card> prizes; // If list.Len == 0 => the prize are Points that are used to upgrade cards.


    }
}