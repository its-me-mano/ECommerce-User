using System;
using System.Collections.Generic;
using System.Linq;
using ECommerce_User.Dbcontexts;
using ECommerce_User.Helper;
using ECommerce_User.Entities.Model;

namespace ECommerce_User.Services
{
    public class UserDetailsRepositories : IUserDetailRepositories
    {
        private readonly UserDetailsContext _context;
        public UserDetailsRepositories(UserDetailsContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        ///<summary>
        ///Get the user by pagelist
        ///</summary>
        ///<param name="userResourceParameter"></param>
        public PageList<User> GetUsers(UserResourceParameter userResourceParameter)
        {
            if (userResourceParameter == null)
            {
                throw new ArgumentNullException(nameof(userResourceParameter));
            }
            IQueryable<User> Collection = _context.Users as IQueryable<User>;
            if (!string.IsNullOrWhiteSpace(userResourceParameter.FirstName))
            {
                string Query = userResourceParameter.FirstName;
                Collection = Collection.Where(a => a.FirstName.Contains(Query));
            }
            if (userResourceParameter.OrderType != null)
            {
                if (userResourceParameter.OrderType.Equals("DESC"))
                {
                    Collection = Collection.OrderByDescending(a => userResourceParameter.OrderBy.Equals("FirstName") ? a.FirstName : a.LastName);
                }
                else 
                {
                    Collection = Collection.OrderBy(a => userResourceParameter.OrderBy.Equals("FirstName") ? a.FirstName : a.LastName);
                }
            }
            return PageList<User>.Create(Collection, userResourceParameter.PageNo, userResourceParameter.PageSize);
        }
        ///<summary>
        /// check meta data exist or not
        ///</summary>
        ///<param name="type"></param>
        public bool metaExist(string type)
        {
            return _context.RefTerms.Any(a => a.Key == type);
        }
        /// <summary>
        /// Check the card is already exist or not in the database
        /// </summary>
        /// <param name="CardNumber"></param>
        /// <returns></returns>
        public bool CardExist(string cardNumber) {
            return _context.Cards.Any(a => a.CardNumber == cardNumber);
        }
        /// <summary>
        /// check the upi is already exist or not in the database
        /// </summary>
        /// <param name="UPI"></param>
        /// <returns></returns>
        public bool UPIExist(string UPI) {
            return _context.UPIS.Any(a => a.UPIID == UPI);
        }
       
        /// <summary>
        /// Convert the GUID into user role 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetRole(Guid id)
        {
            var value = _context.RefTerms.Where(a => a.Id == id).FirstOrDefault();
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            else
            {
                return value.Key;
            }
        }
        ///<summary>
        /// find the type of the Refset
        ///</summary>
        /// <param name="type"></param>
        public RefTerm TypeFinder(string type)
        {
            return _context.RefTerms.FirstOrDefault(b => b.Key == type);
        }
        ///<summary>
        ///delete the user
        ///</summary>
        ///<param name="user"></param>
        public void DeleteUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _context.Users.Remove(user);
        }
        ///<summary>
        ///check mail exist or not
        ///</summary>
        ///<param name="email"></param>
        public bool EmailExist(string email)
        {
            return _context.Emails.Any(a => a.EmailAddress == email);
        }
        ///<summary>
        ///add the users
        ///</summary>
        ///<param name="user"></param>
        public void AddUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));
            _context.Users.Add(user);
        }

        ///<summary>
        ///get the users
        ///</summary>
        ///<param name="id"></param>

        public User GetUser(Guid id) 
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return _context.Users.Where(a=>a.Id==id).FirstOrDefault();
        }
        ///<summary>
        ///update the users
        ///</summary>
        ///<param name="userId"></param>
        ///<param name="user"></param>
        public void UpdateUser(User user,Guid userId)
        {
            User Data = _context.Users.Where(a => a.Id == userId).FirstOrDefault();
            _context.SaveChanges();
        }
        ///<summary>
        ///get the list of users
        ///</summary>
       
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
        ///<summary>
        ///count of the users
        ///</summary>
        public int GetCount()
        {
            List<User> All = _context.Users.ToList();
            return All.Count;
        }
        ///<summary>
        ///lis of email of the users
        ///</summary>
        public IEnumerable<Email> GetEmails()
        {
            return _context.Emails.ToList();
        }
        ///<summary>
        ///save the users
        ///</summary>
        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
        ///<summary>
        ///check the user exist ot ot
        ///</summary>
        ///<param name="userId"></param>
        public bool UserExits(Guid userId)
        {
            if (userId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(userId));
            }
            return _context.Users.Any(a => a.Id == userId);
        }

        ///<summary>
        ///get the address ids 
        ///</summary>
        ///<param name="id"></param>
        public IEnumerable<Address> GetAddressIds(Guid id)
        {
            return _context.Addresses.Where(a => a.UserId == id);
        }
        ///<summary>
        ///get the phone number by id
        ///</summary>
        ///<param name="id"></param>
        public IEnumerable<Phone> GetPhoneIds(Guid id)
        {
            return _context.Phones.Where(a => a.UserId == id);
        }
        public IEnumerable<Email> GetEmailIds(Guid id)
        {
            return _context.Emails.Where(a => a.UserId == id);
        }

        ///<summary>
        ///cget the asset
        ///</summary>
        ///<param name="userId"></param>
        public Guid getAssetId(Guid userId)
        {
            return _context.Assets.Where(a => a.UserId.Equals(userId)).FirstOrDefault().Id;

        }

        ///<summary>
        ///update the asset
        ///</summary>
        ///<param name="assetDto"></param>
        public void UpdateAsset(Asset assetDto)
        {

        }
        ///<summary>
        ///add the asset
        ///</summary>
        ///<param name="assetDto"></param>
        public void AddAsset(Asset assetDto)
        {
            _context.Assets.Add(assetDto);
        }
        ///<summary>
        ///check the asset exist or not
        ///</summary>
        ///<param name="id"></param>
        public bool CheckAsset(Guid id)
        {
            return _context.Assets.Any(a => a.UserId == id);
        }
        ///<summary>
        ///get the assetId  by id
        ///</summary>
        ///<param name="id"></param>
        public Asset GetAssetById(Guid id)
        {
            return _context.Assets.FirstOrDefault(a => a.UserId.Equals(id));
        }
        ///<summary>
        ///get the assetId 
        ///</summary>
        ///<param name="id"></param>
        public IEnumerable<Asset> GetAssetIds(Guid id)
        {
            return _context.Assets.Where(a => a.UserId == id);
        }
        /// <summary>
        /// Check whethere the type of the card exist or not
        /// </summary>
        /// <param name="type"></param>
        /// <param name="LoggedUserId"></param>
        public bool CardTypeExist(string type, Guid LoggedUserId) {
            return _context.Cards.Where(a => a.Id == LoggedUserId).Any(a => a.type == type);
        }
        ///<summary>
        /// get the list of card by id
        ///</summary>
        ///<param name="id"></param>
        public IEnumerable<Card> GetCardIds(Guid id)
        {
            return _context.Cards.Where(a => a.UserId.Equals(id));
        }
        ///<summary>
        /// get the list of upi by id
        ///</summary>
        ///<param name="id"></param>
        public IEnumerable<UPI> GetUPIIds(Guid id)
        {
            return _context.UPIS.Where(a => a.UserId.Equals(id));
        }



    }
}
