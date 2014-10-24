using System;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;

namespace OauthService
{
    public class LinkedInOauthClient : IOath2Client
    {
        private const string RedeemAuthCodeUrl =
            "https://www.linkedin.com/uas/oauth2/accessToken?grant_type=authorization_code&code={0}&redirect_uri={1}&client_id={2}&client_secret={3}";

        private const string ApiUrl = "https://api.linkedin.com/v1/";

        public OathAccessToken RedeemAuthorizationCode(string authorizationCode, string returnUrl, string apiKey,
            string secretKey)
        {
            var url = string.Format(RedeemAuthCodeUrl, authorizationCode, returnUrl, apiKey, secretKey);

            OathAccessToken token;
            using (var client = new HttpClient())
            {
                var address = new Uri(url);

                using (var response = client.GetAsync(address).Result)
                {
                    response.EnsureSuccessStatusCode();
                    var content = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result);
                    token = new OathAccessToken()
                    {
                        AccessToken = content.access_token,
                        ExpiresIn = content.expires_in
                    };
                }
            }
            return token;
        }

        public string QueryDataSource(OathAccessToken token, string searchString)
        {
            using (var client = new HttpClient())
            {
                var url = new Uri(string.Concat(ApiUrl, searchString));

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", token.AccessToken));
                client.DefaultRequestHeaders.Add("x-li-format", "json");

                using (var response = client.GetAsync(url).Result)
                {
                    response.EnsureSuccessStatusCode();
                    var resultvalue = response.Content.ReadAsStringAsync().Result;
                    return resultvalue;
                }
            }
        }

    }

}
