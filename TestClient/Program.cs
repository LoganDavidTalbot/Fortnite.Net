using Fortnite.Net;
using Fortnite.Net.Clients;
using Fortnite.Net.Resources;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Profile pl = new FortniteClient("INSERT TOKEN HERE").GetProfile("pc", "loglt");

            var kd = pl.LifeTimeStats.KD;

            Console.ReadKey();
        }
    }
}
