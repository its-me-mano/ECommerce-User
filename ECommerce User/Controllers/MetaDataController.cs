﻿using ECommerce_User.Contracts;
using ECommerce_User.Entities.Dto;
using ECommerce_User.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_User.Controllers
{
    [ApiController]
    [Route("api/meta-data/ref-set")]
    public class MetaDataController : ControllerBase
    {
        private readonly IMetaDataServices _service;
        private readonly ILogger _logger;
        public MetaDataController( IMetaDataServices service,ILogger logger)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            
        }
        /// <summary>
        /// Metadata API
        /// </summary>
        /// <remarks>To get the metadata list like Address Type, Email address type, phone number type, country</remarks>
        /// <param name="searchKey"></param>
        /// <response code="200">Success</response>
        /// <response code="404">NotFound</response>
        /// <response code="400">The user input is not valid.</response>
        /// <response code="401">The user is not authorized.</response>
        /// <response code="500">Internal Server Error</response>
        [SwaggerOperation("Metadata API")]
        [SwaggerResponse(statusCode: 200, "Success!")]
        [SwaggerResponse(statusCode: 400, "The user input is not valid", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 401, "The user is not authorized", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 404, "The user  is not found", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 500, "Internal Server Error", typeof(ErrorDto))]
        [Authorize]
        [HttpGet("{Key}")]
        public IActionResult RefSet([FromRoute(Name ="Key")][Required]string Key) {
            _logger.LogInformation("Search metadata initiated");
            MetaDataDto value = _service.FetchMetaData(Key);
            if (value == null)
            {
                _logger.LogError("Key not found");
                return StatusCode(404, _service.ErrorToReturn("404", "Key not found"));
            }
            else {
                _logger.LogInformation("MetaData found successfully");
                return Ok(value);
            }
        }
    
    }
}
