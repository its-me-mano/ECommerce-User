using ECommerce_User.Contracts;
using ECommerce_User.Dbcontexts;
using ECommerce_User.Entities.Model;
using System;
using System.Linq;

namespace ECommerce_User.Repositories
{
    public class LoginRepositories : ILoginRepositories
    {
        private readonly UserDetailsContext _context;
        public LoginRepositories(UserDetailsContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }
        ///<summary>
        /// Get the email id of the user
        ///</summary>
        ///<param name="email"></param>
        public User GetUser(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return _context.Users.Where(a => a.Id == id).FirstOrDefault();
        }
        ///<summary>
        /// Get the particular user  
        ///</summary>
        ///<param name="id"></param>
        public Guid EmailIdOfUser(string email)
        {
            IQueryable<Email> Collection = _context.Emails as IQueryable<Email>;
            if (!string.IsNullOrWhiteSpace(email))
            {
                email = email.Trim();
                Collection = Collection.Where(a => a.EmailAddress == email);
            }
            Email item = Collection.FirstOrDefault();
            if (item == null)
                throw new ArgumentNullException(nameof(email));
            return item.UserId;
        }
        /// <summary>
        /// Convert the GUID into user role 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetRole(Guid id) {
            var value=_context.RefTerms.Where(a => a.Id == id).FirstOrDefault();
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            else {
                return value.Key;
            }  
        }
    }
}
