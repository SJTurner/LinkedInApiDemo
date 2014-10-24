using System.Configuration;
using System.Web.Mvc;
using LinkedInApiDemo.Models;
using OauthService;
using Newtonsoft.Json;

namespace LinkedInApiDemo.Controllers
{
    public class ProfileController : Controller
    {
        private const string SearchCriteria = "people/~:(first-name,last-name,educations)";

        public ActionResult Index(string code, string state)
        {
            var oauthClient = new LinkedInOauthClient();
            var token = oauthClient.RedeemAuthorizationCode(code, ConfigurationManager.AppSettings["ReturnUrl"], ConfigurationManager.AppSettings["ApiKey"], ConfigurationManager.AppSettings["SecretKey"]);
            var result = oauthClient.QueryDataSource(token, SearchCriteria);

            var model = JsonConvert.DeserializeObject<ProfileModel>(result);
            return View("Index", model);
        }
    }
}