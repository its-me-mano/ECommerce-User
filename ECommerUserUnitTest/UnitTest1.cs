using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Security.Claims;
using ECommerce_User.Controllers;
using ECommerce_User.Contracts;
using ECommerce_User.Services;
using ECommerce_User.Dbcontexts;
using AutoMapper;
using CacheManager.Core;
using ECommerUserUnitTest.InMemoryContext;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using ECommerce_User.Repositories;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ECommerce_User.Profiles;
using Microsoft.AspNetCore.Mvc;
using ECommerce_User.Models;
using Microsoft.AspNetCore.Http;

namespace ECommerUserUnitTest
{
    public class UnitTest1
    {
        UserController UserController;
        MetaDataController MetaDataController;
        FileController FileController;
        LoginController loginController;
        UserDetailsContext context;
        IUserServices UserService;
        IMetaDataServices MetaDataService;
        ILoginServices LoginService;
        IFileServices FileService;
        IUserDetailRepositories userDetailRepository;
        ILoginRepositories loginRepository;
        IMetaDataRepositories metaDataRepository;
        IFileRepositories fileRepository;
        IMapper _mapper;
        private readonly IConfiguration configuration;
        private ClaimsPrincipal user;
        private Guid userId;
        public UnitTest1()
        {
             configuration = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            userId = new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be");
            //create claims
            user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier,userId.ToString())
                                        // other required and custom claims
                           }, "TestAuthentication"));
            //Adding Claims


            using var services = new ServiceCollection().AddSingleton<IConfiguration>(configuration).BuildServiceProvider();
            context = InMemorydbContext.userDetailsContext();
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder().
            ConfigureLogging((builderContext, loggingBuilder) =>
            {
                loggingBuilder.AddConsole((options) =>
                {
                    options.IncludeScopes = true;
                });
            });
            IHost host = hostBuilder.Build();
            ILogger<UserController> logger = host.Services.GetRequiredService<ILogger<UserController>>();

            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Automapper());
            });
           

            IMapper mapper = mappingConfig.CreateMapper();
            _mapper = mapper;
            userDetailRepository = new UserDetailsRepositories(context);
            metaDataRepository = new MetaDataRepositories(context);
            loginRepository = new LoginRepositories(context);
            fileRepository = new FileRepositories(context);
            UserService = new UserServices(userDetailRepository, _mapper,configuration,logger);
            MetaDataService = new MetaDataServices(metaDataRepository, _mapper);
            LoginService = new LoginServices(loginRepository);
            FileService = new FileServices(fileRepository, _mapper, configuration);
            UserController = new UserController( _mapper, UserService, logger);
            MetaDataController = new MetaDataController( MetaDataService, logger);
            loginController = new LoginController(logger, configuration, LoginService);
            FileController = new FileController( mapper, FileService, logger);
        }
        [Fact]
        public void GetUser_Ok()
        {
            //Checking userId
            Guid userId = new Guid("68417748-6864-4866-8d9b-b82ae29da396");
            var Response = UserController.GetUser(userId);
            Assert.IsType<OkObjectResult>(Response);
        }
        [Fact]
        public void GetUser_NotFound()
        {
            //Checking userId
            Guid userId = new Guid("68417748-6864-4866-8d9b-b82ae29da391");
            var Response = UserController.GetUser(userId);
            Assert.Equal(404, (Response as ObjectResult).StatusCode);
        }
        [Fact]
        public void CreateUser_Created()
        {
            UserCreatingDto userCreatingDto = new UserCreatingDto()
            {
                FirstName = "Power",
                LastName = "Ranger",
                password = "Satkhi@321",
                Addresses = new List<AddressCreatingDto>(),
                Emails = new List<EmailCreatingDto>(),
                Phones = new List<PhoneCreatingDto>()
            };
            userCreatingDto.Addresses.Add(new AddressCreatingDto()
            {
                Line1 = "182",
                Line2 = "sellur",
                City = "Madurai",
                StateName = "tamilnadu",
                Zipcode = "234234",
                Type = "PERSONAL",
                Country = "INDIA"
            });
            userCreatingDto.Emails.Add(new EmailCreatingDto()
            {
                EmailAddress = "Hello@gmail.com",
                type = "PERSONAL",
            });
            userCreatingDto.Phones.Add(new PhoneCreatingDto()
            {
                PhoneNumber = "1234567891",
                type = "PERSONAL"
            });
            //create claims
            Guid userId = new Guid("68417748-6864-4866-8d9b-b82ae29da396");
            ClaimsPrincipal user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier,userId.ToString())
                                        // other required and custom claims
                           }, "TestAuthentication"));
            //Adding Claims
            UserController.ControllerContext = new ControllerContext();
            UserController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };
            IActionResult CreateResponse = UserController.CreateUser(userCreatingDto);
            Assert.IsType<ObjectResult>(CreateResponse);
            Assert.Equal(201, (CreateResponse as ObjectResult).StatusCode);
            Guid id = new Guid((CreateResponse as ObjectResult).Value.ToString());
            Assert.IsType<Guid>(id);
        }
        [Fact]
        public void CreateUser_Conflict()
        {
            UserCreatingDto userCreatingDto = new UserCreatingDto()
            {
                FirstName = "Power",
                LastName = "Ranger",
                password = "Satkhi@321",
                Addresses = new List<AddressCreatingDto>(),
                Emails = new List<EmailCreatingDto>(),
                Phones = new List<PhoneCreatingDto>()
            };
            userCreatingDto.Addresses.Add(new AddressCreatingDto()
            {
                Line1 = "182",
                Line2 = "sellur",
                City = "Madurai",
                StateName = "tamilnadu",
                Zipcode = "234234",
                Type = "PERSONAL",
                Country = "INDIA"
            });
            userCreatingDto.Emails.Add(new EmailCreatingDto()
            {
                EmailAddress = "itsmemano123@gmail.com",
                type = "PERSONAL",
            });
            userCreatingDto.Phones.Add(new PhoneCreatingDto()
            {
                PhoneNumber = "1234567891",
                type = "PERSONAL"
            });
            //create claims
            Guid userId = new Guid("68417748-6864-4866-8d9b-b82ae29da396");
            ClaimsPrincipal user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier,userId.ToString())
                                        // other required and custom claims
                           }, "TestAuthentication"));
            //Adding Claims
            UserController.ControllerContext = new ControllerContext();
            UserController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };
            IActionResult CreateResponse = UserController.CreateUser(userCreatingDto);
            Assert.IsType<ObjectResult>(CreateResponse);
            Assert.Equal(409, (CreateResponse as ObjectResult).StatusCode);
         
        }
        [Fact]
        public void CreateUser_NotFound()
        {
            UserCreatingDto userCreatingDto = new UserCreatingDto()
            {
                FirstName = "Power",
                LastName = "Ranger",
                password = "Satkhi@321",
                 Addresses = new List<AddressCreatingDto>(),
                Emails = new List<EmailCreatingDto>(),
                Phones = new List<PhoneCreatingDto>()
            };
            userCreatingDto.Addresses.Add(new AddressCreatingDto()
            {
                Line1 = "182",
                Line2 = "sellur",
                City = "Madurai",
                StateName = "tamilnadu",
                Zipcode = "234234",
                Type = "PERSONAL",
                Country = "INDIA"
            });
            userCreatingDto.Emails.Add(new EmailCreatingDto()
            {
                EmailAddress = "itsme@gmail.com",
                type = "PERSONAL",
            });
            userCreatingDto.Phones.Add(new PhoneCreatingDto()
            {
                PhoneNumber = "1234567891",
                type = "PERSONA"
            });
            //create claims
            Guid userId = new Guid("68417748-6864-4866-8d9b-b82ae29da396");
            ClaimsPrincipal user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier,userId.ToString())
                                        // other required and custom claims
                           }, "TestAuthentication"));
            //Adding Claims
            UserController.ControllerContext = new ControllerContext();
            UserController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };
            IActionResult CreateResponse = UserController.CreateUser(userCreatingDto);
            Assert.IsType<ObjectResult>(CreateResponse);
            Assert.Equal(404, (CreateResponse as ObjectResult).StatusCode);
           
        }

        [Fact]
        public void LoginUser()
        {
            LoginCredentialsDto loginCredentials = new LoginCredentialsDto()
            {
                EmailAddress = "itsmemano123@gmail.com",
                Password = "Hello@123"
            };
            IActionResult response = loginController.UserLogin(loginCredentials);
            Assert.IsType<JsonResult>(response);


        }
        [Fact]
        public void LoginUser_NotAuthorized()
        {

            LoginCredentialsDto loginCredentials1 = new LoginCredentialsDto()
            {
                EmailAddress = "itsmemano@gmail.com",
                Password = "Hello@123"
            };
            IActionResult response = loginController.UserLogin(loginCredentials1);
            Assert.Equal(401, (response as ObjectResult).StatusCode);


        }

        [Fact]
        public void ImageUpload()
        {
            
            string path = @"C:\Users\Manoj\source\repos\ECommerce User\ECommerce User\Dbcontexts\response.jpg";
            IFormFile File;

            //Adding Claims
            FileController.ControllerContext = new ControllerContext();
            FileController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };
            using (FileStream stream = System.IO.File.OpenRead(path))
            {
                File = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name));
                IActionResult response = FileController.UploadFiles(File);
                Assert.IsType<JsonResult>(response);
            };
        }


        [Fact]
        public void GetUserCount()
        {
            UserController.ControllerContext = new ControllerContext();
            UserController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };
            OkObjectResult response = UserController.GetCount() as OkObjectResult;
            Assert.IsType<string>(response.Value);
            Assert.Equal("count:2", response.Value);
        }

        [Fact]
        public void GetAllUsers()
        {
            IActionResult Response = UserController.GetUsers(1,2,"FirstName","ASC");
            Assert.IsType<OkObjectResult>(Response);
        }

        [Fact]
        public void ImageDownload_Ok()
        {
            Guid assetId = new Guid("f98972b6-04e4-4577-b21c-946e96bef643");
            IActionResult response = FileController.DownloadFile(assetId.ToString());
            Assert.IsType<FileContentResult>(response);
        }
        [Fact]
        public void ImageDownload_NoObject()
        {
            
            IActionResult response = FileController.DownloadFile(null);
            Assert.Equal(400, (response as ObjectResult).StatusCode);
        }


        [Fact]
        public void RefsetData_Test_Ok()
        {
            string key = "PHONE_NUMBER_TYPE";
            IActionResult response = MetaDataController.RefSet(key);
            Assert.IsType<OkObjectResult>(response);
            Assert.Equal(200, (response as ObjectResult).StatusCode);  
        }

        [Fact]
        public void RefsetData_Test_NotFound()
        {
            string key2 = "_TYPE";
            IActionResult response2 = MetaDataController.RefSet(key2);
            Assert.Equal(404, (response2 as ObjectResult).StatusCode);
        }


        [Fact]
        public void UpdateUserController_Ok()
        {
            
          
            UserUpdatingDto userUpdatingDto = new UserUpdatingDto()
            {
                FirstName = "Power",
                LastName = "Ranger",
                password = "Satkhi@321",
                Addresses = new List<AddressUpdatingDto>(),
                Emails = new List<EmailUpdatingDto>(),
                Phones = new List<PhoneUpdatingDto>()
            };
            userUpdatingDto.Addresses.Add(new AddressUpdatingDto()
            {
                Line1 = "182",
                Line2 = "sellur",
                City = "Madurai",
                StateName = "tamilnadu",
                Zipcode = "234234",
                Type = "PERSONAL",
                Country = "INDIA"
            });
            userUpdatingDto.Emails.Add(new EmailUpdatingDto()
            {
                EmailAddress = "itsme1233321@gmail.com",
                type = "PERSONAL",
            });
            userUpdatingDto.Phones.Add(new PhoneUpdatingDto()
            {
                PhoneNumber = "1234567891",
                type = "PERSONAL"
            });
            Guid userId = new Guid("68417748-6864-4866-8d9b-b82ae29da396");
            //create claims
            ClaimsPrincipal user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier,userId.ToString())
                                        // other required and custom claims
                           }, "TestAuthentication"));
            //Adding Claims
            UserController.ControllerContext = new ControllerContext();
            UserController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };
            //updateResult
            IActionResult UpdateReturn = UserController.UpdateUser( userUpdatingDto);
            Assert.IsType<OkObjectResult>(UpdateReturn);
            Assert.Equal(200, (UpdateReturn as ObjectResult).StatusCode);


        }
        [Fact]
        public void UpdateUserController_Conflict()
        {


            UserUpdatingDto userUpdatingDto = new UserUpdatingDto()
            {
                FirstName = "Power",
                LastName = "Ranger",
                password = "Satkhi@321",
                Addresses = new List<AddressUpdatingDto>(),
                Emails = new List<EmailUpdatingDto>(),
                Phones = new List<PhoneUpdatingDto>()
            };
            userUpdatingDto.Addresses.Add(new AddressUpdatingDto()
            {
                Line1 = "182",
                Line2 = "sellur",
                City = "Madurai",
                StateName = "tamilnadu",
                Zipcode = "234234",
                Type = "PERSONAL",
                Country = "INDIA"
            });
            userUpdatingDto.Emails.Add(new EmailUpdatingDto()
            {
                EmailAddress = "itsmemano123@gmail.com",
                type = "PERSONAL",
            });
            userUpdatingDto.Phones.Add(new PhoneUpdatingDto()
            {
                PhoneNumber = "1234567891",
                type = "PERSONAL"
            });
            //Adding Claims
            UserController.ControllerContext = new ControllerContext();
            UserController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };
            //updateResult
            IActionResult UpdateReturn = UserController.UpdateUser( userUpdatingDto);
            Assert.Equal(409, (UpdateReturn as ObjectResult).StatusCode);


        }




        [Fact]
        public void DeleteUser_Ok() {
            UserController.ControllerContext = new ControllerContext();
            UserController.ControllerContext.HttpContext = new DefaultHttpContext { User = user };
            IActionResult response = UserController.DeleteUser();
            Assert.Equal(200, (response as ObjectResult).StatusCode);
        }



    }
}
