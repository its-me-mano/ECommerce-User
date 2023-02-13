using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_User.Entities.Dto
{
    public class CardCreatingDto
    {
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
        /// type of the card
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string type { get; set; }
    }
}
