﻿using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_User.Models
{
    public class AddressDto
    {
        ///<summary>
        ///address Id
        ///</summary>
        public Guid Id { get; set; }
        ///<summary>
        ///user id
        ///</summary>
        [JsonProperty(PropertyName = "user_id")]
        public Guid UserId { get; set; }

        ///<summary>
        /// street 1  of the user 
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "line1")]
        public string Line1 { get; set; }



        ///<summary>
        /// street 2 of the user 
        ///</summary>
        [JsonProperty(PropertyName = "line2")]
        public string Line2 { get; set; }

        ///<summary>
        /// city of the user 
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        ///<summary>
        /// state  of the user 
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "state_name")]
        public string StateName { get; set; }


        ///<summary>
        /// zip code of the user 
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "zipcode")]
        public string Zipcode { get; set; }


        [Required]
        [JsonProperty(PropertyName = "type")]
        public Guid Type { get; set; }

        ///<summary>
        /// first name of the user 
        ///</summary>
        [Required]
        [JsonProperty(PropertyName = "country")]
        public Guid Country { get; set; }
    }
}
