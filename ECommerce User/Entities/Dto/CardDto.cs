using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_User.Entities.Dto
{
    public class CardDto
    {
        /// <summary>
        /// Id of the Card
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid Id {get;set;}
        /// <summary>
        /// UserId of the card owner
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public Guid UserId { get; set; }
        /// <summary>
        /// Card holder name for the card
        /// </summary>
        [JsonProperty(PropertyName = "cardholder_name")]
        public string CardholderName { get; set; }
        /// <summary>
        /// Cardnumber of the  card
        /// </summary>
        [JsonProperty(PropertyName = "card_number")]
        public string CardNumber { get; set; }
        /// <summary>
        /// CVV number of the card
        /// </summary>
        [JsonProperty(PropertyName = "cvv")]
        public string CVV { get; set; }
        /// <summary>
        /// type of the cared
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string type { get; set; }
    }
}
