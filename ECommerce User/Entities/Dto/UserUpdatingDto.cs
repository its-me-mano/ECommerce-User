using ECommerce_User.Entities.Dto;
using ECommerce_User.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_User.Models
{
    public class UserUpdatingDto : BaseModelDto

    {
        ///<summary>
        ///User FirstName
        ///</summary>
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Letters only")]
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        ///<summary>
        ///User LastName
        ///</summary>
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Letters only")]
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
        ///<summary>
        ///user password
        ///</summary>
        [RegularExpression(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$", ErrorMessage = "Password must be one lower case , one upper case , special character,one number and 8 characters length")]
        public string password { get; set; }
        ///<summary>
        ///list of address
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "addresses")]
        public ICollection<AddressUpdatingDto> Addresses { get; set; } = new List<AddressUpdatingDto>();
        ///<summary>
        ///list of email 
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "emails")]
        public ICollection<EmailUpdatingDto> Emails { get; set; } = new List<EmailUpdatingDto>();
        ///<summary>
        ///list of phone
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "phones")]
        public ICollection<PhoneUpdatingDto> Phones { get; set; } = new List<PhoneUpdatingDto>();
        ///<summary>
        /// list of assetDto
        ///</summary>
        [JsonProperty(PropertyName = "assets")]
        public ICollection<AssetDtoCreating> Assets { get; set; } = new List<AssetDtoCreating>();
        ///<summary>
        /// picuture of the user 
        ///</summary>
        [JsonProperty(PropertyName = "upis")]
        public ICollection<UPIUpdatingDto> UPIS { get; set; } = new List<UPIUpdatingDto>();
        ///<summary>
        /// picuture of the user 
        ///</summary>
        [JsonProperty(PropertyName = "cards")]
        public ICollection<CardUpdatingDto> Cards { get; set; } = new List<CardUpdatingDto>();
        /*        ///<summary>
                ///role of user
                /// </summary>
                [JsonProperty(PropertyName = "role")]
                public Guid role { get; set; }
        */
    }
}
