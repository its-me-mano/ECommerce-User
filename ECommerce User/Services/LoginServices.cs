using ECommerce_User.Contracts;
using ECommerce_User.Entities.Dto;
using ECommerce_User.Entities.Model;
using ECommerce_User.Helper;
using ECommerce_User.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace ECommerce_User.Services
{
    public class LoginServices : ILoginServices
    {
        private readonly ILoginRepositories loginRepository;

        public LoginServices(ILoginRepositories _loginRepository)
        {
            loginRepository = _loginRepository ?? throw new ArgumentNullException(nameof(_loginRepository));

        }
        ///<summary>
        /// Generate webtoken
        ///</summary>
        ///<param name="userInfo"></param>
        ///<param name="_config"></param>
        public string GenerateJSONWebToken(User userInfo, IConfiguration _config) 
        {
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            string role = loginRepository.GetRole(userInfo.role);
            Claim[] claims = new[] {
            new Claim(JwtRegisteredClaimNames.Sub, userInfo.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.Sub, userInfo.LastName),
            new Claim(JwtRegisteredClaimNames.Sub, role),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.Role,role)
            };
            JwtSecurityToken token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
       /// <summary>
        /// Get the role of the user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string IdentifyUserRole(Guid id) {
            return loginRepository.GetRole(id);
        }
        ///<summary>
        /// fetch the user by email
        ///</summary>
        ///<param name="input"></param>
        public User GetUserByEmail(string email) {
            Guid UserId = loginRepository.EmailIdOfUser(email);
            return loginRepository.GetUser(UserId);
        }
        ///<summary>
        /// Validated the user
        ///</summary>
        ///<param name="input"></param>
        public bool AuthenticateUser(User login, LoginCredentialsDto input)
        {
            //Validate the User Credentials    
            return login.Password == input.Password;
        }
        ///<summary>
        ///Return Error in the format
        ///</summary>
        ///<param name="description"></param>
        ///<param name="statuscode"></param>
        public ErrorDto ErrorToReturn(string statuscode, string description)
        {
            ErrorManage errorManage = new ErrorManage();
            return errorManage.ReturningError(statuscode, description);
        }
    }
}
