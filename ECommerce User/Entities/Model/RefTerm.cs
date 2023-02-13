﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ECommerce_User.Entities.Model
{
    public class RefTerm : BaseModel
    {

        ///<summary>
        /// reterm key 
        ///</summary>
        [Required]
        [DataMember(Name = "key")]
        public string Key { get; set; }

        ///<summary>
        /// description of the key 
        ///</summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
