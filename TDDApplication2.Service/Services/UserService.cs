using AutoMapper;
using TDDApplication2.DataAccessLayer.Repositories.Interfaces;
using TDDApplication2.DTO.DTOs;
using TDDApplication2.Service.Services.Interfaces;
using TDDApplication2.Service.Utilities.CustomExceptions;

namespace TDDApplication2.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<UserDTO>> GetUsersAsync()
        {
            var usersToReturn = await _userRepository.GetListAsync();

            return _mapper.Map<List<UserDTO>>(usersToReturn);
        }

        public UserDTO GetUser(int userId)
        {
            var userToReturn = _userRepository.Get(userId);

            if (userToReturn is null)
            {
                throw new UserNotFoundException();
            }

            return _mapper.Map<UserDTO>(userToReturn);
        }
    }
}
