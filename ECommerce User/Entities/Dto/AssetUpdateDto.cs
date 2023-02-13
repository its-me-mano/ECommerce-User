using ECommerce_User.Entities.Dto;
using Newtonsoft.Json;
using System;

namespace ECommerce_User.Models
{
    public class AssetUpdateDto : BaseModelDto
    {
        ///<summary>
        ///Asset Id
        ///</summary>
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }
    }
}
