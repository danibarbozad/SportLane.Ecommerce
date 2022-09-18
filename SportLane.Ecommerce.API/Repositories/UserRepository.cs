using SportLane.Ecommerce.API.Context;
using SportLane.Ecommerce.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace SportLane.Ecommerce.API.Repositories
{
    public class UserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User Get(string username, string password)
        {
            return _context.Users.Where(x => x.UserName.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }

        public User Create(User user)
        {
            return _context.Users.Add(user).Entity;
        }
    }
}
