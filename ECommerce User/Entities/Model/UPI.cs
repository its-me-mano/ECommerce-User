using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ECommerce_User.Entities.Model
{
    public class UPI : BaseModel
    {
        /// <summary>
        /// UserId of the upi owner
        /// </summary>
        [ForeignKey("UserId")]
        [DataMember(Name ="user_id")]
        public Guid UserId { get; set; }
        /// <summary>
        /// upi id of the user
        /// </summary>
        [DataMember(Name ="upi_id")]
        public string UPIID { get; set; }
        /// <summary>
        /// type of card
        /// </summary>
        [DataMember(Name = "type")]
        public string type { get; set; }
    }
}
