using TDDApplication2.DTO.DTOs;

namespace TDDApplication2.Service.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetUsersAsync();
        UserDTO GetUser(int userId);
    }
}
