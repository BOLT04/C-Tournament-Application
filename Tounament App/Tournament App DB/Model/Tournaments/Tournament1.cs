﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentAppDB.Model.Tournaments {
    public class Tournament1 : Tournament {

        private readonly string ENEMY1_NAME = "John";
        private readonly string ENEMY2_NAME = "Scar";
        private readonly string ENEMY3_NAME = "Roy Mustang";

        public Tournament1() {
            Enemies = new List<Enemy> {
                new Enemy(ENEMY1_NAME),
                new Enemy(ENEMY2_NAME),
                new Enemy(ENEMY3_NAME)
            };
        }

        public Tournament1(string playerName) : this() {
            Player = new Player(playerName);
        }
    }
}