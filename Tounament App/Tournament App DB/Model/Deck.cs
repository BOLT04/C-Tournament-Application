using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TournamentAppDB.Model {
    public class Deck : IEnumerable<Card>{
        private readonly int ARR_SIZE = 10;

        private HearthstoneDBClient hDBClient;

        public List<Card> Cards { get; set; }

        [StringLength(maximumLength:12)]
        public string Name { get; set; }

        public string Path { get; set; }

        public Deck() {
            hDBClient = new HearthstoneDBClient();
            Cards = new List<Card>();

            FillCards();
        }

        public Deck(string name, string path) : this() {
            Name = name;
            Path = path;

            Validate();
        }

        private void Validate() {
            ValidationContext context = new ValidationContext(this, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(this, context, results, true);

            if (!valid) 
                throw new ArgumentException("The name of the deck is too long:" + Name);
        }


        (string name, string id)[] keysAux = {
            ("Shadowfiend", "AT_014"),
            ("Holy Champion", "AT_011"),
            ("Fallen Hero", "AT_003"),
            ("Ram Wrangler", "AT_010"),
            ("Coldarra Drake", "AT_008"),
            ("Rhonin", "AT_009")
        };

        /// <summary>
        /// Populate the list of cards with cards from the auxiliary container: keysAux.
        /// </summary>
        private void FillCards() {
            foreach ((string name, string id) in keysAux) {
                Card card = hDBClient.GetCard(name, id);
                Cards.Add(card);
            }
        }

        public IEnumerator<Card> GetEnumerator() {
            return Cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
