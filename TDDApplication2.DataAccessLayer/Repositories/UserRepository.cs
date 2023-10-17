using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TDDApplication2.DataAccessLayer.DataContext;
using TDDApplication2.DataAccessLayer.Entities;
using TDDApplication2.DataAccessLayer.Repositories.Interfaces;

namespace TDDApplication2.DataAccessLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public UserRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public User Get(int userid)
        {
            //return _applicationDbContext.Users.Where(user => user.UserId == userid).FirstOrDefault();
            return new User
            {
                Name = "Test",
                Password = "Test",
                Surname = "Test",
                UserId = 1,
                Username = "Test"
            };
        }

        public async Task<List<User>> GetListAsync()
        {
            return new List<User> {
            new User{
            Name = "Test",
                Password = "Test",
                Surname = "Test",
                UserId = 1,
                Username = "Test"} };
            //return await _applicationDbContext.Users.ToListAsync();
        }
    }
}