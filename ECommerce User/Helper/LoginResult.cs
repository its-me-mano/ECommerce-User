
namespace ECommerce_User.Helper
{
    public class LoginResult
    {
        ///<summary>
        ///Store the accessToken
        ///</summary>
        public string accessToken { get; set; }
        ///<summary>
        ///TokenType
        ///</summary>
        public string tokenType = "Bearer";

        public string role { get; set; }
    }
}
