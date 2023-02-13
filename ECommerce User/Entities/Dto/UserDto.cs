using ECommerce_User.Entities.Dto;
using ECommerce_User.Entities.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ECommerce_User.Models
{
    public class UserDto 
    {
        ///<summary>
        ///UserDto Id
        ///</summary>
        public Guid Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [JsonProperty(PropertyName = "first_name")]
        ///<summary>
        ///user FirstName
        ///</summary>
        public string FirstName { get; set; }
        ///<summary>
        ///User LastName
        ///</summary>
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
        ///<summary>
        ///List of addresses
        ///</summary>
        [JsonProperty(PropertyName = "addresses")]
        [Required]
        public ICollection<AddressDto> Addresses { get; set; } = new List<AddressDto>();
        ///<summary>
        ///List of emails
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "emails")]
        public ICollection<EmailDto> Emails { get; set; } = new List<EmailDto>();
        ///<summary>
        ///List of phone numbers
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "phones")]
        public ICollection<PhoneDto> Phones { get; set; } = new List<PhoneDto>();
        ///<summary>
        ///List of assets
        ///</summary>
        [JsonProperty(PropertyName = "assets")]
        public ICollection<AssetDto> Assets { get; set; } = new List<AssetDto>();
        ///<summary>
        /// picuture of the user 
        ///</summary>
        [JsonProperty(PropertyName = "upis")]
        public ICollection<UpiDto> UPIS { get; set; } = new List<UpiDto>();
        ///<summary>
        /// picuture of the user 
        ///</summary>
        [JsonProperty(PropertyName = "cards")]
        public ICollection<CardDto> Cards { get; set; } = new List<CardDto>();
        ///<summary>
        ///role of user
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public Guid role { get; set; }

    }
}
