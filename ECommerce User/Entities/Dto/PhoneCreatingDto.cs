﻿using ECommerce_User.Entities.Dto;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace ECommerce_User.Models
{
    public class PhoneCreatingDto : BaseModelDto
    {
        ///<summary>
        ///Phonenumber 
        ///</summary>
        [Phone(ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        [Required]
        [MinLength(10)]
        [JsonProperty(PropertyName = "phone_number")]
        public string PhoneNumber { get; set; }
        ///<summary>
        ///Phone number type
        ///</summary>
        [JsonProperty(PropertyName = "type")]
        public string type { get; set; }
    }
}
