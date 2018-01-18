using Newtonsoft.Json;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using TournamentAppDB.Model;

namespace TournamentAppDB {
    public class HearthstoneDBClient {
        
        WebClient client = new WebClient();

        readonly string API_URL = "https://api.hearthstonejson.com/v1/22611/enUS/cards.collectible.json";

        //The key is the name of the card which should be unique
        //The value is the card object that is associated with that name.
        private Dictionary<string, Card> cards = new Dictionary<string, Card>();

        public HearthstoneDBClient() {
            string body = client.DownloadString(API_URL);

            //Alternate way to get the JSON string
            //Useful in custom JSON files.
            //string body = System.IO.File.ReadAllText(@"C:\Users\JoséDavid\source\repos\C-Tournament-Application\Tounament App\Tounament App\res\Poseidon.txt");

            Card[] searchItem = (Card[])JsonConvert.DeserializeObject(body, typeof(Card[]));

            //Initialize dictionary.
            cards = searchItem.ToDictionary(c => c.name);
        }

        public Card GetCard(string name)
        {
            return cards[name];
        }

       

    }
}
