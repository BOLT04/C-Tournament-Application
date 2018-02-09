﻿using System.Collections.Generic;
using TournamentAppDB.Properties;

namespace TournamentAppDB.Model.Users {
    public class GameUser {
        public string Name { get; set; }

        /// <summary>
        /// Represents the cards on the hand of the enemy.
        /// </summary>
        public List<Card> Hand { get; set; }

        public GameUser() {
            Hand = new List<Card>(int.Parse(Resources.MAX_HAND_CARDS));
        }

        public GameUser(string name) : this() {
            Name = name;
        }
    }
}
