namespace TournamentAppDB.Model.Users {
    public class Enemy : GameUser{
        public Deck Deck { get; set; } = new Deck();// This is initiated here since its redundant to put it
                                                    // in both constructors.

        public Enemy() { }

        public Enemy(string name) : base(name) { }

        public Enemy(string name, Deck deck) : this(name) {
            Deck = deck;
        }
    }
}
