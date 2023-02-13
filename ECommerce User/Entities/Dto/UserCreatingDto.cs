using ECommerce_User.Entities.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_User.Models
{
    public class UserCreatingDto : BaseModelDto
    {
        ///<summary>
        ///First name of the user
        ///</summary>
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }
        ///<summary>
        ///last name of the user
        ///</summary>
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
        ///<summary>
        ///password of the user
        ///</summary>
        [RegularExpression(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$", ErrorMessage = "Password must be one lower case , one upper case , special character,one number and 8 characters length")]
        public string password { get; set; }
        ///<summary>
        ///list of address
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "address")]
        public ICollection<AddressCreatingDto> Addresses { get; set; } = new List<AddressCreatingDto>();
        ///<summary>
        ///list of emails
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "emails")]
        public ICollection<EmailCreatingDto> Emails { get; set; } = new List<EmailCreatingDto>();
        ///<summary>
        ///list of phones
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "phones")]
        public ICollection<PhoneCreatingDto> Phones { get; set; } = new List<PhoneCreatingDto>();
        ///<summary>
        ///list of assets
        ///</summary>
        [JsonProperty(PropertyName = "assets")]
        public ICollection<AssetDtoCreating> Assets { get; set; } = new List<AssetDtoCreating>();
        ///<summary>
        /// picuture of the user 
        ///</summary>
        [JsonProperty(PropertyName = "upis")]
        public ICollection<UPICreatingDto> UPIS { get; set; } = new List<UPICreatingDto>();
        ///<summary>
        /// picuture of the user 
        ///</summary>
        [JsonProperty(PropertyName = "cards")]
        public ICollection<CardCreatingDto> Cards { get; set; } = new List<CardCreatingDto>();
        ///<summary>
        ///role of user
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public Guid role { get; set; }
    }
}
