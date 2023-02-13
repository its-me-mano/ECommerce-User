using ECommerce_User.Models;


namespace ECommerce_User.Helper
{
    public class ReturnUpdateStatus
    {
        ///<summary>
        ///return status number
        ///</summary>
        public int status { get; set; }
        ///<summary>
        ///return status description
        ///</summary>
        public string description { get; set; }
        ///<summary>
        ///Updatinguser
        ///</summary>
        public UserUpdatingDto user { get; set; }
    }
}
