using ECommerce_User.Entities.Dto;
using ECommerce_User.Entities.Model;
using ECommerce_User.Models;
using Microsoft.Extensions.Configuration;
using System;

namespace ECommerce_User.Contracts
{
    public interface ILoginServices
    {
        ///<summary>
        /// Generate webtoken
        ///</summary>
        ///<param name="userInfo"></param>
        ///<param name="_config"></param>
        string GenerateJSONWebToken(User userInfo, IConfiguration _config);
        ///<summary>
        /// Validated the user
        ///</summary>
        ///<param name="input"></param>
        bool AuthenticateUser(User login, LoginCredentialsDto input);
        ///<summary>
        /// Return the user
        ///</summary>
        ///<param name="input"></param>
        User GetUserByEmail(string email);
        ///<summary>
        ///Return Error in the format
        ///</summary>
        ///<param name="description"></param>
        ///<param name="statuscode"></param>
        ErrorDto ErrorToReturn(string statuscode, string description);
        /// <summary>
        /// Get the role of the user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string IdentifyUserRole(Guid id);
    }
}
