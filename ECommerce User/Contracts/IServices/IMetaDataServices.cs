using ECommerce_User.Entities.Dto;
using ECommerce_User.Models;

namespace ECommerce_User.Contracts
{
    public interface IMetaDataServices 
    {
        ///<summary>
        /// find the key from the metadata 
        ///</summary>
        ///<param name="key"></param>
        MetaDataDto FetchMetaData(string key);

        ///<summary>
        ///Return Error in the format
        ///</summary>
        ///<param name="description"></param>
        ///<param name="statuscode"></param>
        ErrorDto ErrorToReturn(string statuscode, string description);
    }
}
