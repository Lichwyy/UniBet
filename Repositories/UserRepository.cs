using UniBet.Data.Contexts;
using UniBet.Interfaces.IRepositories;
using UniBet.Entities;

namespace UniBet.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }


        public User FindUserById(Guid id)
        {
            User user = _context.Users.FirstOrDefault(usr => usr.Id == id);

            return user;
        }
    }
}
