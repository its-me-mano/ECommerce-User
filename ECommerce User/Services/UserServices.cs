﻿using AutoMapper;
using ECommerce_User.Entities.Dto;
using ECommerce_User.Entities.Model;
using ECommerce_User.Helper;
using ECommerce_User.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
namespace ECommerce_User.Services
{
    public class UserServices : IUserServices

    {
        private readonly IUserDetailRepositories userDetailRepository;
        private IConfiguration configuration;
        private readonly IMapper mapper;
        private readonly ILogger logger;
        public UserServices(IUserDetailRepositories _userDetailRepository,IMapper _mapper,IConfiguration _configuration,ILogger _logger)
        {
            userDetailRepository = _userDetailRepository ?? throw new ArgumentNullException(nameof(_userDetailRepository));
            mapper = _mapper ?? throw new ArgumentNullException(nameof(_mapper));
            configuration = _configuration ?? throw new ArgumentNullException(nameof(_configuration));
            logger = _logger;
        }

        ///<summary>
        ///Adding the appdning the values email,address
        ///</summary>
        /// <param name="userId"></param>
        /// <param name="userFromRepo"></param>
        public void AppendingValueForUpdate(User userFromRepo,Guid userId,UserUpdatingDto user,Guid userLogin) {
            List<Address> addressess = userDetailRepository.GetAddressIds(userId).ToList();
            userFromRepo.Addresses.Select((value, index) => value.Id = addressess[index].Id);
            List<Email> emails = userDetailRepository.GetEmailIds(userId).ToList();
            userFromRepo.Emails.Select((value, index) => value.Id = emails[index].Id);
            List<Phone> phones = userDetailRepository.GetPhoneIds(userId).ToList();
            userFromRepo.Phones.Select((value, index) => value.Id = phones[index].Id);
            List<Card> cards = userDetailRepository.GetCardIds(userId).ToList();
            userFromRepo.Phones.Select((value, index) => value.Id = cards[index].Id);
            List<UPI> upis = userDetailRepository.GetUPIIds(userId).ToList();
            userFromRepo.UPIS.Select((value, index) => value.Id = upis[index].Id);
            mapper.Map(user, userFromRepo);
            userFromRepo.DateUpdated = DateTime.Now;
            userFromRepo.UpdateBy = userLogin;
            userDetailRepository.UpdateUser(userFromRepo, userId);
            userDetailRepository.Save();
        }

        ///<summary>
        ///get the logged user 
        ///</summary>
        ///<param name="user"></param>
        public string GetLoggedId(ClaimsPrincipal User){
            string LoggedUserId=String.Empty;
             if (!String.IsNullOrEmpty(ClaimTypes.NameIdentifier))
                 LoggedUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
             return LoggedUserId;
        }
        /// <summary>
        /// Get the user role
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        public string GetUserRole(ClaimsPrincipal User) {
            string LoggedUserId = String.Empty;
            if (!String.IsNullOrEmpty(ClaimTypes.NameIdentifier))
                LoggedUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            else {
                throw new NullReferenceException(nameof(User));
            }
            var user = userDetailRepository.GetUser(new Guid(LoggedUserId));
            return userDetailRepository.GetRole(user.role);
        }
        /// <summary>
        /// Get the count of the users
        /// </summary>
        public int GetCount() {
            return userDetailRepository.GetCount();
        }
        /// <summary>
        /// Get the users
        /// </summary>
        /// <param name="userResourceParameter"></param>
        public PageList<User> GetUsers(UserResourceParameter userResourceParameter) {
            return userDetailRepository.GetUsers(userResourceParameter);
        }
        /// <summary>
        /// Get the particular user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public User GetUser(Guid userId)
        {
            return userDetailRepository.GetUser(userId); 
        }
        /// <summary>
        /// Delete the particular user
        /// </summary>
        /// <param name="userFromRepo"></param>
        public void DeleteUser(User userFromRepo) {
            userDetailRepository.DeleteUser(userFromRepo);
            userDetailRepository.Save();
        }
        /// <summary>
        /// SavetheCreateDto user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public UserDto SaveCreateUser(UserCreatingDto user) {
           
       
            User userEntity = mapper.Map<User>(user);
            userDetailRepository.AddUser(userEntity);
            userDetailRepository.Save();
          
            return mapper.Map<UserDto>(userEntity);
        }

        /// <summary>
        /// Does the user exist or not
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public bool UserExists(Guid userId) {
            return userDetailRepository.UserExits(userId);
        }
        ///<summary>
        ///Return Error in the format
        ///</summary>
        ///<param name="description"></param>
        ///<param name="statuscode"></param>
        public ErrorDto ErrorToReturn(string statuscode, string description) {
            ErrorManage errorManage = new ErrorManage();
            return errorManage.ReturningError(statuscode, description);
        }
        ///<summary>
        ///Update the userdetails  in the address,email,phone
        ///</summary>
        /// <param name="user"></param>
        /// <param name="LoggedUserId"></param>
        public ReturnCreateStatus CreateTheUser(UserCreatingDto user, Guid LoggedUserId) {
            ReturnCreateStatus returnCreate = new ReturnCreateStatus();
            foreach (EmailCreatingDto item in user.Emails)
            {
                if (!userDetailRepository.metaExist(item.type))
                {
                    logger.LogError("Email type is not exist");
                    returnCreate.status = 404;
                    returnCreate.description = "Email type is not exist";
                    returnCreate.user = user;
                    return returnCreate;
                }
                if (userDetailRepository.EmailExist(item.EmailAddress))
                {
                    logger.LogError("Email is already exist");
                    returnCreate.status = 409;
                    returnCreate.description = "Email is already exist";
                    returnCreate.user = user;
                    return returnCreate;

                }
                item.type = RefTermKeyToGuidString(item.type);

            }
            foreach(CardCreatingDto card in user.Cards) {
                if (userDetailRepository.CardExist(card.CardNumber)) {
                    logger.LogError("Card is already  exist");
                    returnCreate.status = 409;
                    returnCreate.description = "Card is already exist";
                    returnCreate.user = user;
                    return returnCreate;
                }
                if (userDetailRepository.CardTypeExist(card.type, LoggedUserId)) {
                    logger.LogError("Card type  is already exist");
                    returnCreate.status = 409;
                    returnCreate.description = "Card type is already with this name";
                    returnCreate.user = user;
                    return returnCreate;
                }
            }
            foreach (PhoneCreatingDto item in user.Phones)
            {
                if (!userDetailRepository.metaExist(item.type))
                {
                    logger.LogError("Phone number type is not exist");
                    returnCreate.status = 404;
                    returnCreate.description = "phone number type is not exist";
                    returnCreate.user = user;
                    return returnCreate;
                }
                item.type = RefTermKeyToGuidString(item.type);

            }
            foreach (AddressCreatingDto item in user.Addresses)
            {
                if (!userDetailRepository.metaExist(item.Country))
                {
                    logger.LogError($"Countrytype is not exist{item.Country}");
                    returnCreate.status = 404;
                    returnCreate.description = "Country  type is not exist";
                    returnCreate.user = user;
                    return returnCreate;
                }
                if (!userDetailRepository.metaExist(item.Type))
                {
                    logger.LogError("Addresstype is not exist");
                    returnCreate.status = 404;
                    returnCreate.description = "Addresstype is not exist";
                    returnCreate.user = user;
                    return returnCreate;
                    
                }
                item.Type = RefTermKeyToGuidString(item.Type);
                item.Country =RefTermKeyToGuidString(item.Country);

            }
            returnCreate.user = user;
            returnCreate.status = 200;
            returnCreate.description = "Created Successfully";
            return returnCreate;
        }


        ///<summary>
        ///Update the userdetails  in the address,email,phone
        ///</summary>
        /// <param name="user"></param>
        /// <param name="LoggedUserId"></param>
        public ReturnUpdateStatus UpdateTheUser(UserUpdatingDto user,Guid LoggedUserId) {
            ReturnUpdateStatus errorReturn = new ReturnUpdateStatus();
            foreach (EmailUpdatingDto item in user.Emails)
            {
                if (userDetailRepository.EmailExist(item.EmailAddress))
                {
                    logger.LogError("Email is already existed");
                    errorReturn.status = 409;
                    errorReturn.description = "Email is already exist";
                    errorReturn.user = user;
                    return errorReturn;
                }
                if (!userDetailRepository.metaExist(item.type))
                {
                    logger.LogError("Email type is not existed");
                    errorReturn.status = 404;
                    errorReturn.description = "Email type is not exist";
                    errorReturn.user = user;
                    return errorReturn;
                }
                item.type = (userDetailRepository.TypeFinder(item.type)).Id.ToString();

            }
            foreach (CardUpdatingDto card in user.Cards)
            {
                if (userDetailRepository.CardExist(card.CardNumber))
                {
                    logger.LogError("Card is already  exist");
                    errorReturn.status = 409;
                    errorReturn.description = "Card is already exist";
                    errorReturn.user = user;
                    return errorReturn;
                }
                if (userDetailRepository.CardTypeExist(card.type, LoggedUserId))
                {
                    logger.LogError("Card type  is already exist");
                    errorReturn.status = 409;
                    errorReturn.description = "Card type is already with this name";
                    errorReturn.user = user;
                    return errorReturn;
                }
            }
            foreach (PhoneUpdatingDto item in user.Phones)
            {
                if (!userDetailRepository.metaExist(item.type))
                {
                    logger.LogError("Phone number type  is not existed");
                    errorReturn.status = 404;
                    errorReturn.description = "Phone number type is not exist";
                    errorReturn.user = user;
                    return errorReturn;
                }
                item.type = (userDetailRepository.TypeFinder(item.type)).Id.ToString();

            }
            foreach (AddressUpdatingDto item in user.Addresses)
            {
                if (!userDetailRepository.metaExist(item.Country))
                {
                    logger.LogError($"Countrytype is not exist{item.Country}");
                    errorReturn.status = 404;
                    errorReturn.description = "CountryType  type is not exist";
                    errorReturn.user = user;
                    return errorReturn;  
                }
                if (!userDetailRepository.metaExist(item.Type))
                {
                    logger.LogError($"Addresstype is not exist");
                    errorReturn.status = 404;
                    errorReturn.description = "Address type is not exist";
                    errorReturn.user = user;
                    return errorReturn;
                }
                item.Type = (userDetailRepository.TypeFinder(item.Type)).Id.ToString();
                item.Country = (userDetailRepository.TypeFinder(item.Country)).Id.ToString();

            }
            errorReturn.user = user;
            errorReturn.status = 200;
            errorReturn.description = "updated successfullly";
            return errorReturn;
        }
        ///<summary>
        ///check the page number is exist or not
        ///</summary>
        /// <param name="PageSize"></param>
        /// <param name="PageNo"></param>
        public bool checkPageNumberLimit(int PageSize,int PageNo) {
            int CountBook = userDetailRepository.GetCount();
            double MaxPageNo = (double)CountBook / (double)(PageSize);
            int MaxiPage = Convert.ToInt32(Math.Ceiling(MaxPageNo));
            return MaxiPage < PageNo;
        }

        ///<summary>
        ///PageList append the items
        ///</summary>
        ///<param name="items"></param>
        public PageList<User> AppendingValues(PageList<User> items) {
            foreach (User user in items)
            {
                user.Emails = userDetailRepository.GetEmailIds(user.Id).ToList();
                user.Addresses = userDetailRepository.GetAddressIds(user.Id).ToList();
                user.Phones =userDetailRepository.GetPhoneIds(user.Id).ToList();
                user.Assets = userDetailRepository.GetAssetIds(user.Id).ToList();
                user.Cards = userDetailRepository.GetCardIds(user.Id).ToList();
                user.UPIS = userDetailRepository.GetUPIIds(user.Id).ToList();
            }
            return items;
        }

        ///<summary>
        ///Append the userid
        ///</summary>
        ///<param name="userId"></param>
        public User AppendingValueForUser(Guid userId) {
            User UserFromRepo = userDetailRepository.GetUser(userId);
            UserFromRepo.Emails = userDetailRepository.GetEmailIds(UserFromRepo.Id).ToList();
            UserFromRepo.Addresses = userDetailRepository.GetAddressIds(UserFromRepo.Id).ToList();
            UserFromRepo.Phones = userDetailRepository.GetPhoneIds(UserFromRepo.Id).ToList();
            UserFromRepo.Assets = userDetailRepository.GetAssetIds(UserFromRepo.Id).ToList();
            UserFromRepo.Cards = userDetailRepository.GetCardIds(UserFromRepo.Id).ToList();
            UserFromRepo.UPIS = userDetailRepository.GetUPIIds(UserFromRepo.Id).ToList();
            return UserFromRepo;
        }
        ///<summary>
        ///Convert type type to  reftermKey  guid as string
        ///</summary>
        ///<param name="type"></param>
        public string RefTermKeyToGuidString(string type) {
            return (userDetailRepository.TypeFinder(type)).Id.ToString();
        }

        


      

    }
}

