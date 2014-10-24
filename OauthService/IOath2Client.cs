
namespace OauthService
{
    public interface IOath2Client
    {
        OathAccessToken RedeemAuthorizationCode(string authorizationCode, string returnUrl, string apiKey, string secretKey);
        string QueryDataSource(OathAccessToken token, string searchString);
    }
}
