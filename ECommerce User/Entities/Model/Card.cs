using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ECommerce_User.Entities.Model
{
    public class Card : BaseModel
    {
        /// <summary>
        /// UserId of the card owner
        /// </summary>
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        /// <summary>
        /// Card holder name for the card
        /// </summary>
        [DataMember(Name = "cardholder_name")]
        public string CardholderName { get; set; }
        /// <summary>
        /// Cardnumber of the  card
        /// </summary>
        [DataMember(Name = "card_number")]
        public string CardNumber { get; set; }
        /// <summary>
        /// CVV number of the card
        /// </summary>
        [DataMember(Name = "cvv")]
        public string CVV { get; set; }
        /// <summary>
        /// type of the card 
        /// </summary>
        [DataMember(Name = "upi_id")]
        public string type { get; set; }
    }
}
