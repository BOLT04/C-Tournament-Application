﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TournamentAppDB.Model {
    public class Deck {
        private readonly int ARR_SIZE = 10;

        private HearthstoneDBClient hDBClient;

        public List<Card> Cards { get; set; }

        //[Verifier(typeof(StringVerifier))]
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
            ("Flame Lance", "AT_001"),
            ("Effigy", "AT_002"),
            ("Fallen Hero", "AT_003"),
            ("Arcane Blast", "AT_004")
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
    }

    class VerifierAttribute : Attribute {
        /// <summary>
        /// Represents the type responsible to verify the value the user is trying to assign
        /// to the member with this attribute.
        /// </summary>
        public Type VerifierType;
        public VerifierAttribute(Type type) { VerifierType = type; }
    }
}
