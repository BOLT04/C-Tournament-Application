using Newtonsoft.Json;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using TournamentAppDB.Model;
using System;

namespace TournamentAppDB {
    public class HearthstoneDBClient {
        
        private WebClient client = new WebClient();

        readonly string API_URL = "https://api.hearthstonejson.com/v1/22611/enUS/cards.json";

        //The key is a tuple since the name of a card isn't unique enough.
        //1st element being the name of the card and the 2nd being the card's id.
        //The value is the card object that is associated with that name.
        private Dictionary<(string, string), Card> cards = new Dictionary<(string, string), Card>();

        public HearthstoneDBClient() {
            string body = client.DownloadString(API_URL);

            //Alternate way to get the JSON string
            //Useful in custom JSON files.
            //string body = System.IO.File.ReadAllText(@"C:\Users\JoséDavid\source\repos\C-Tournament-Application\Tounament App\Tounament App\res\Poseidon.txt");

            Card[] cards = (Card[])JsonConvert.DeserializeObject(body, typeof(Card[]));

            //Initialize dictionary from the cards array.
            this.cards = cards.ToDictionary(c => (c.Name, c.Id));
        }

        public Card GetCard(string name, string id) {
            Card c = cards[(name, id)];

            if (c == null)// Then it means there is no card associated with that key.
                throw new ArgumentException("There is no card in the database with the name: " + name +
                                            ", and id: " + id);
            return c;
        }

    }
}
