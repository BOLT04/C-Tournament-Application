using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TournamentAppDB.Model {
    public class Deck {
        public List<Card> Cards { get; set; }

        //[Verifier(typeof(StringVerifier))]
        [StringLength(maximumLength:12)]
        public string Name { get; set; }

        public string Path { get; set; }

        public Deck() {
            Cards = new List<Card>();
            
        }

        public Deck(string name, string path) : this() {
            Name = name;
            Path = path;
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
