using System;
using RestSharp;
using Newtonsoft.Json;


namespace b_face
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");

            RestRequest request = new RestRequest("pokemon/probopass");

            IRestResponse response = client.Get(request);


            Pokemon probopass = JsonConvert.DeserializeObject<Pokemon>(response.Content);

            Console.WriteLine("Name: " + probopass.name);
            System.Console.WriteLine("Id: " + probopass.id);


            Console.ReadLine();

        }
    }
}
