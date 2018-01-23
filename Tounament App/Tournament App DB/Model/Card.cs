using Newtonsoft.Json;

namespace TournamentAppDB.Model {
    public class Card {

        /// <summary>
        /// Represents the card's attack value.
        /// </summary>
        [JsonProperty("attack")]
        public int Attack { get; set; }


        /// <summary>
        /// Represents the card's mana cost.
        /// </summary>
        [JsonProperty("cost")]
        public int Cost { get; set; }


        /// <summary>
        /// Represents the card's health value.
        /// </summary>
        [JsonProperty("health")]
        public int Health { get; set; }


        /// <summary>
        /// Unique identifier of a specific card.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Represents the flavor text of the card.
        /// </summary>
        [JsonProperty("flavor")]
        public string Flavor { get; set; }

        [JsonProperty("cardClass")]
        public string CardClass { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("race")]
        public string Race { get; set; }


        /// <summary>
        /// Type of the card.
        /// Possible values = SPELL, WEAPON, MINION, HERO
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("mechanics")]
        public string[] Mechanics { get; set; }

    }
}
