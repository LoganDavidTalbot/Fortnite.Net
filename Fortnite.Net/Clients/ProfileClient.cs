using Fortnite.Net.Resources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Fortnite.Net.Extensions;
using System.Linq;
using System.Net.Http.Headers;

namespace Fortnite.Net.Clients
{
    public class ProfileClient
    {
        private HttpClient _client;
        private string _version;
        private string _path;
        private string _host;
        private string _key;
        public ProfileClient(
            string version,
            string host,
            string key)
        {            
            _version = version;
            _host = host;
            _path = $"/{_version}/profile/";
            _client = new HttpClient();
            _key = key;
        }

        public async Task<Profile> GetProfileAsync(string platform, string name)
        {
            Profile player = null;

            _client.BaseAddress = new Uri(_host);
            _client.DefaultRequestHeaders.Add("TRN-Api-Key", _key);

            HttpResponseMessage res = await _client.GetAsync($"{_path}/{platform}/{name}");

            if (res.IsSuccessStatusCode && res.Content.Headers.ContentType.MediaType.Contains("application/json"))
            {
                player = res.ContentAsType<Profile>();
            }

            player.init();

            return player;
        }
    }
}
