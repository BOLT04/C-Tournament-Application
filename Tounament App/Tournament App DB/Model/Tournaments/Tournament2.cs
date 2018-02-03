using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentAppDB.Model.Users;

namespace TournamentAppDB.Model.Tournaments {
    public class Tournament2: Tournament {
        public static bool Locked { get; set; } = true;// The default value its true to signal that it's locked.

        private readonly string ENEMY1_NAME = "Greed";
        private readonly string ENEMY2_NAME = "Pride";
        private readonly string ENEMY3_NAME = "Envy";
        private readonly string ENEMY4_NAME = "Wrath";

        public Tournament2() {
            Locked = false;

            Enemies = new List<Enemy> {
                new Enemy(ENEMY1_NAME),
                new Enemy(ENEMY2_NAME),
                new Enemy(ENEMY3_NAME),
                new Enemy(ENEMY4_NAME)
            };
        }

        public Tournament2(string playerName) : this() {
            Player = new Player(playerName);
        }
    }
}
