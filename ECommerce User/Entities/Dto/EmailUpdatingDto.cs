using ECommerce_User.Entities.Dto;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;


namespace ECommerce_User.Models
{
    public class EmailUpdatingDto : BaseModelDto
    {
        ///<summary>
        ///email address
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "email_address")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Enter Valid email address")]
        public string EmailAddress { get; set; }
        ///<summary>
        ///email Id
        ///</summary>
        public Guid Id { get; set; }
        ///<summary>
        ///email type
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "type")]
        public string type { get; set; }

    }
}
