using System.Collections.Generic;

namespace TournamentAppDB.Model {
    public class Tournament {
        private string Name;
        private bool locked;
        //private List<Enemy> enemies;
        private int timesPlayed;
        private List<Card> prizes; // If list.Len == 0 => the prize are Points that are used to upgrade cards.
    }
}