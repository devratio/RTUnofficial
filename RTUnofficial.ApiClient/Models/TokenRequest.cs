using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RTUnofficial.ApiClient.Models
{
    //public enum GrantType { Password };
    //public enum Scope { UserPublic };

    public class TokenRequest
    {
        [JsonProperty("client_id")]
        public string ClientId { get; set; } = "4338d2b4bdc8db1239360f28e72f0d9ddb1fd01e7a38fbb07b4b1f4ba4564cc5";

        [JsonProperty("grant_type")]
        public string /*GrantType*/ GrantType { get; set; } = "password"/*GrantType.Password*/;

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("scope")]
        public string /*Scope*/ Scope { get; set; } = "user public"/*Scope.UserPublic*/;

        [JsonProperty("username")]
        public string Username { get; set; }

        public static TokenRequest FromJson(string json) => JsonConvert.DeserializeObject<TokenRequest>(json, Converter.Settings);
    }




}
