namespace Services
{
    public interface IOath2Client
    {
        OathAccessToken RedeemAuthorizationCode(string authorizationCode, string returnUrl, string apiKey, string secretKey);
        dynamic QueryDataSource(OathAccessToken token, string searchString);
    }
}
