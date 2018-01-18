using Newtonsoft.Json;

namespace TournamentAppDB.Model {
    public class Card {

        [JsonProperty("attack")]
        public int Attack { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("health")]
        public int Health { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("flavor")]
        public string Flavor { get; set; }

        [JsonProperty("cardClass")]
        public string CardClass { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("race")]
        public string Race { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("mechanics")]
        public string[] Mechanics { get; set; }

    }
}
