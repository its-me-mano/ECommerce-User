using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ECommerce_User.Entities.Model
{
    public class User : BaseModel
    {

        ///<summary>
        /// password of the user
        ///</summary>
        [Required]
        [DataMember(Name = "password")]
        [RegularExpression(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$", ErrorMessage = "Password must be one lower case , one upper case , special character,one number and 8 characters length")]
        public string Password { get; set; }
        ///<summary>
        /// first name of the user 
        ///</summary>
        [Required]
        [DataMember(Name = "first_name")]
        public string FirstName { get; set; }
        ///<summary>
        /// last name of the user 
        ///</summary>
        [DataMember(Name = "last_name")]
        public string LastName { get; set; }
        ///<summary>
        /// address of the user 
        ///</summary>
        [DataMember(Name = "address")]
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
        ///<summary>
        /// email address of the user 
        ///</summary>
        [DataMember(Name = "emails")]
        public ICollection<Email> Emails { get; set; } = new List<Email>();
        ///<summary>
        /// phone number of the user 
        ///</summary>
        [DataMember(Name = "phones")]
        public ICollection<Phone> Phones { get; set; } = new List<Phone>();
        ///<summary>
        /// picuture of the user 
        ///</summary>
        [DataMember(Name = "assets")]
        public ICollection<Asset> Assets { get; set; } = new List<Asset>();
        ///<summary>
        /// picuture of the user 
        ///</summary>
        [DataMember(Name = "upis")]
        public ICollection<UPI> UPIS { get; set; } = new List<UPI>();
        ///<summary>
        /// picuture of the user 
        ///</summary>
        [DataMember(Name = "cards")]
        public ICollection<Card> Cards { get; set; } = new List<Card>();

        ///<summary>
        ///role of user
        /// </summary>
        [DataMember(Name ="role")]
        public Guid role { get; set; }

    }
}
