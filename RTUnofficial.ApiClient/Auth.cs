using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Windows.Security.Credentials;

namespace RTUnofficial.ApiClient
{
    public static class Auth
    {
        private const string TOKEN_RESOURCE = "RT";
        private const string TOKEN_USER = "TOKEN";

        public static Models.Token Token { get; set; }

        public static bool IsLoggedIn { get; set; } = false;

        private static readonly HttpClient _client = new HttpClient();
        private static readonly PasswordVault _vault = new PasswordVault();

        public static bool LogIn(string username, string password)
        {

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>the current stored token, or null if it doesn't exist</returns>
        private static Models.Token GetTokenFromCredentialsStore()
        {
            try // because there is no method for checking if a value exists in the vault...
            {
                PasswordCredential cred_ = _vault.Retrieve(TOKEN_RESOURCE, TOKEN_USER);

                return Models.Token.FromJson(cred_.Password);
            }
            catch
            {
                return null;
            }
        }

        private static void SaveTokenInCredentialsStore()
        {
            _vault.Add(new PasswordCredential(TOKEN_RESOURCE, TOKEN_USER, Models.Serialize.ToJson(Token)));
        }
    }
}
