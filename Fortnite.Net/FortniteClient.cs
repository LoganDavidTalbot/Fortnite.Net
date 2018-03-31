using Fortnite.Net.Clients;
using Fortnite.Net.Enum;
using Fortnite.Net.Interfaces;
using Fortnite.Net.Resources;
using System;
using System.Net.Http;

namespace Fortnite.Net
{
    public class FortniteClient : IFortniteClient
    {
        private ProfileClient _profile;
        private string _version;     
        private string _apiKey;
        private string _host;

        public string ApiKey
        {
            set
            {
                _apiKey = value;
                init();
            }
        }
        public FortniteClient(string apiKey = null)
        {
            _version = "v1";
            _host = "https://api.fortnitetracker.com";
            ApiKey = apiKey;            
        }

        private void init()
        {
            _profile = new ProfileClient(_version, _host , _apiKey);
        }

        public Profile GetPcProfile(string name)
        {
            return GetProfile("pc", name);
        }

        public Profile GetProfile(string platform, string name)
        {
            return _profile.GetProfileAsync(platform, name).Result;
        }

        public Profile GetPsnProfile(string name)
        {
            return GetProfile("psn", name);
        }

        public Profile GetXblProfile(string name)
        {
            return GetProfile("xbl", name);
        }

        public Profile GetProfile(EPlatform platform, string name)
        {
            return GetProfile(GetPlatform(platform), name);
        }

        private string GetPlatform(EPlatform platform)
        {
            string result = "pc";
            if (EPlatform.XBL == platform)
            {
                result = "xbl";
            }
            else if (EPlatform.PSN == platform)
            {
                result = "psn";
            }
            return result;
        }
    }
}
