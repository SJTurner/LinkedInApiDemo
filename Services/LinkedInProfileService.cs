using System;
using System.Configuration;
using System.Net.Http;
using System.Xml;
using Newtonsoft.Json;

namespace Services
{
    public class LinkedInProfileService
    {
        //public static string GetAuthToken(string code)
        //{
        //    var model = "";
        //    OathAccessToken token;
        //    var url =
        //        string.Format(
        //            "https://www.linkedin.com/uas/oauth2/accessToken?grant_type=authorization_code&code={0}&redirect_uri={1}&client_id={2}&client_secret={3}",
        //            code, "http://localhost/LinkedInApiDemo/profile", "77xqae22tb8mr1",
        //            "lGiCN5n3EsJk448V");


        //    using (var client = new HttpClient())
        //    {
        //        var address = new Uri(url);
               
        //        //client.DefaultRequestHeaders.Accept.Clear();
        //        //client.DefaultRequestHeaders.Add("Authorization",string.Format("Bearer {0}",code));

        //        using (var response = client.GetAsync(address).Result)
        //        {
        //            response.EnsureSuccessStatusCode();
        //            var resultvalue = response.Content.ReadAsStringAsync().Result;
        //            token = JsonConvert.DeserializeObject<dynamic>(resultvalue);
                   
        //        }
        //    }

        //    url = "https://api.linkedin.com/v1/people/~:(educations,positions)";
           

        //    using (var client = new HttpClient())
        //    {
        //        var address = new Uri(url);

        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", token.access_token));
        //        client.DefaultRequestHeaders.Add("x-li-format", "json");

        //        using (var response = client.GetAsync(address).Result)
        //        {
        //            response.EnsureSuccessStatusCode();
        //            var resultvalue = response.Content.ReadAsStringAsync().Result;
        //            var doc = JsonConvert.DeserializeObject<dynamic>(resultvalue);

        //            var c = doc.educations;

        //        }

              
        //    }

        //    return model;
        //}
    }
}
