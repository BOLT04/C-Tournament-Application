namespace TournamentAppDB.Model.Users {
    public class GameUser {
        public string Name { get; set; }

        public GameUser() { }

        public GameUser(string name) {
            Name = name;
        }
    }
}
