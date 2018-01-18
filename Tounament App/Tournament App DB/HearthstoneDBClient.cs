using Newtonsoft.Json;
using System.Net;


namespace TournamentAppDB
{
    public class HearthstoneDBClient {
        WebClient client = new WebClient();

        readonly string API_URL = "https://api.hearthstonejson.com/v1/22611/enUS/cards.collectible.json";

        public Card[] GetCards()
        {
            string body = client.DownloadString(API_URL);

            //Alternate way to get the JSON string
            //Useful in custom JSON files.
            //string body = System.IO.File.ReadAllText(@"C:\Users\JoséDavid\source\repos\C-Tournament-Application\Tounament App\Tounament App\res\Poseidon.txt");

            Card[] searchItem = (Card[])JsonConvert.DeserializeObject(body, typeof(Card[]));

            return searchItem;
        }

        public class Card
        {
            public int cost;

            public string name;
        }

    }
}
