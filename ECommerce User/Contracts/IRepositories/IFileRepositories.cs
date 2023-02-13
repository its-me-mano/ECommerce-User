
using ECommerce_User.Entities.Model;
using System;


namespace ECommerce_User.Contracts
{
    public interface IFileRepositories
    {
        ///<summary>
        /// save the file  
        ///</summary>
        bool Save();
        ///<summary>
        /// upload the image  
        ///</summary>
        ///<param name="img"></param>
        public void uploadImage(Asset img);
        ///<summary>
        /// get the image
        ///</summary>
        ///<param name="id"></param>
        public Asset GetImage(Guid id);
    }
}
