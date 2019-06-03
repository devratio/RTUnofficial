using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RTUnofficial.ApiClient.Models
{
    public class Token
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string /*TokenType*/ TokenType { get; set; } = "Bearer";

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; } // ... in seconds? 

        [JsonProperty("scope")]
        public string /*Scope*/ Scope { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        public static Token FromJson(string json) => JsonConvert.DeserializeObject<Token>(json, Converter.Settings);

    }
}
