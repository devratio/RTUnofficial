using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTUnofficial.ApiClient
{
    public static class Endpoints
    {
        public const string SVOD = "https://svod-be.roosterteeth.com/";
        public const string Episodes = "/api/v1/episodes";
        public const string Channels = "/api/v1/channels";
        public const string Shows = "/api/v1/shows";
        public const string Livestreams = "/api/v1/livestreams";

        public const string Auth = "https://auth.roosterteeth.com";
        public const string TokenRequest = "/oauth/token";
        public const string TokenRevoke = "/oauth/token/revoke";
    }
}
