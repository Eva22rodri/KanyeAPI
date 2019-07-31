using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWestAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.kanye.rest";
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;

            // This manual way of pulling out the text of the joke is not good or reliable:
            //int jokeStartIndex = response.IndexOf("value") + 8;
            //int jokeLength = response.Length - jokeStartIndex - 2;
            //string joke = response.Substring(jokeStartIndex, jokeLength

            string joke2 = JObject.Parse(response).GetValue("quote").ToString();

            Console.WriteLine(joke2);
        }
    }
}
