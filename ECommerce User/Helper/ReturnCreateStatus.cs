using ECommerce_User.Models;


namespace ECommerce_User.Helper
{
    public class ReturnCreateStatus
    {
        ///<summary>
        ///status number
        ///</summary>
        public int status { get; set; }
        ///<summary>
        ///description
        ///</summary>
        public string description { get; set; }
        ///<summary>
        ///the user to return
        ///</summary>
        public UserCreatingDto user { get; set; }
    }
}
