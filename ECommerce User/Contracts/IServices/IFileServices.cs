﻿using ECommerce_User.Entities.Dto;
using ECommerce_User.Entities.Model;
using Microsoft.AspNetCore.Http;
using System;

namespace ECommerce_User.Contracts
{
    public interface IFileServices
    {
        ///<summary>
        /// convert the image to string
        ///</summary>
        ///<param name="file"></param>
        string ImageToString(IFormFile file);
        ///<summary>
        /// convert the string to image  
        ///</summary>
        ///<param name="assetId"></param>
        byte[] StringToImage(String assetId);

        ///<summary>
        ///Return Error in the format
        ///</summary>
        ///<param name="description"></param>
        ///<param name="statuscode"></param>
        ErrorDto ErrorToReturn(string statuscode, string description);
        /// <summary>
        /// Saving the image in the database
        /// </summary>
        /// <param name=""></param>
        void SaveImage(Asset ImageEntity);
        /// <summary>
        /// Get the image in the database
        /// </summary>
        /// <param name="assetId"></param>
        /// <returns></returns>
        Asset GetImage(string assetId);
    }
}
