
 using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using ECommerce_User.Contracts;
using ECommerce_User.Models;
using ECommerce_User.Entities.Model;
using ECommerce_User.Entities.Dto;

namespace ECommerce_User.Controllers
{
    [ApiController]
    [Route("api/asset")]

    public class FileController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IFileServices _service;
        private readonly ILogger _logger;
        public FileController(IMapper mapper,IFileServices service,ILogger logger)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _service = service ?? throw new ArgumentNullException(nameof(service));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        /// <summary>
        ///File Upload API
        /// </summary>
        /// <remarks>To upload the image or any file and then map it to an account</remarks>
        /// <param name="userId"></param>
        /// <param name="file"></param>
        /// <response code="200">Floor layout image and tab file info returned successfully</response>
        /// <response code="400">The user input is not valid.</response>
        /// <response code="401">The user is not authorized.</response>
        /// <response code="500">Internal Server Error</response>
        [SwaggerOperation("UploadImage")]
        [SwaggerResponse(statusCode: 201, "Success!")]
        [SwaggerResponse(statusCode: 400, "The user input is not valid", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 401, "The user is not authorized", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 500, "Internal Server Error", typeof(ErrorDto))]
        [Authorize]
        [HttpPost("uploadFile")]
        public IActionResult UploadFiles( [FromForm] IFormFile file)
        {
            string LoggedUserId= User.FindFirstValue(ClaimTypes.NameIdentifier); 
            _logger.LogInformation("Uploading file is processing");
            if (file.Length < 0) 
            {
                _logger.LogError("File is not there");
                return StatusCode(400, _service.ErrorToReturn("400", "There is no file"));
            }
            AssetDtoCreating imageCreateDto = new AssetDtoCreating();
            imageCreateDto.File = _service.ImageToString(file);
            Asset ImageEntity = _mapper.Map<Asset>(imageCreateDto);
            ImageEntity.UserId = new Guid(LoggedUserId);
            ImageEntity.CreateBy = new Guid(LoggedUserId);
            ImageEntity.DateCreated = DateTime.Now;
            ImageEntity.File = imageCreateDto.File;
            _service.SaveImage(ImageEntity); 
            imageCreateDto.Id = ImageEntity.Id;
            imageCreateDto.UserId = new Guid(LoggedUserId);          
            _logger.LogInformation("File uploaded successfully");
            return new JsonResult(imageCreateDto);
        }
        /// <summary>
        ///Download API
        /// </summary>
        /// <remarks>To get the file object and it can be used </remarks>
        /// <param name="assetId"></param>
        /// <response code="200">Floor layout image and tab file info returned successfully</response>
        /// <response code="400">The user input is not valid.</response>
        /// <response code="401">The user is not authorized.</response>
        /// <response code="500">Internal Server Error</response>
        [SwaggerOperation("DownloadImage")]
        [SwaggerResponse(statusCode: 201, "Success!")]
        [SwaggerResponse(statusCode: 400, "The user input is not valid", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 401, "The user is not authorized", typeof(ErrorDto))]
        [SwaggerResponse(statusCode: 500, "Internal Server Error", typeof(ErrorDto))]
        [Authorize]
        [HttpGet("{asset-id}")]
        public IActionResult DownloadFile([Required][FromRoute(Name ="asset-id")]string assetId)
        {
            _logger.LogInformation("Downloading the image initiated");
            if (assetId == null)
            {
                _logger.LogError("AssetId is null");
                return StatusCode(400, _service.ErrorToReturn("400", "AssetId is null"));
            }
            Asset Image64 = _service.GetImage(assetId);    
            MemoryStream outputStream = new MemoryStream(Convert.FromBase64String(Image64.File));
            byte[] bytesInStream = outputStream.ToArray();
            _logger.LogInformation("File downloaded successfully");
            return File(bytesInStream, "APPLICATION/octnet-stream");
        }


    }
}
