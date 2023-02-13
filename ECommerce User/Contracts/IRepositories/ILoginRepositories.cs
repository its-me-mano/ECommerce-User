
using ECommerce_User.Entities.Model;
using System;


namespace ECommerce_User.Contracts
{
    public interface ILoginRepositories
    {
        ///<summary>
        /// Get the email id of the user
        ///</summary>
        ///<param name="email"></param>
        Guid EmailIdOfUser(string email);
        ///<summary>
        /// Get the particular user  
        ///</summary>
        ///<param name="id"></param>
        User GetUser(Guid id);
        /// <summary>
        /// Convert the Guid into ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetRole(Guid id);
    }
}
