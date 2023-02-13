using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_User.Entities.Dto
{
    public class UpiDto
    {
        /// <summary>
        /// Id of the Card
        /// </summary>
        [JsonProperty(PropertyName ="id")]
        public Guid Id { get; set; }
        /// <summary>
        /// UserId of the card owner
        /// </summary>
        [JsonProperty(PropertyName ="user_id")]
        public Guid UserId { get; set; }
        /// <summary>
        /// UPI Id
        /// </summary>
        [JsonProperty(PropertyName = "upi_id")]
        public string UPIID { get; set; }
        /// <summary>
        /// This is used to name the type of the card
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string type { get; set; }
    }
}
