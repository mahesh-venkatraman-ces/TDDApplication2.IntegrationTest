using AutoFixture.Xunit2;
using AutoMapper;
using Moq;
using TDDApplication2.DataAccessLayer.AutomapperProfiles;
using TDDApplication2.DataAccessLayer.Entities;
using TDDApplication2.DataAccessLayer.Repositories.Interfaces;
using TDDApplication2.Service.Services;
using TDDApplication2.Service.Services.Interfaces;
using FluentValidation;

namespace TDDApplication2.IntegrationTest.Services
{
    public class UserServiceTests
    {
        private readonly IUserService _userService;
        private readonly Mock<IUserRepository> _userRepository;
        private readonly IMapper _mapper;

        public UserServiceTests()
        {
            var myProfile = new AutoMapperProfiles.AutoMapperProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(myProfile));
            _mapper = new Mapper(configuration);
            _userRepository =new Mock<IUserRepository>();

            _userService = new UserService(_userRepository.Object, _mapper);
        }

        [Theory]
        [AutoData]
        public async Task GetUsersAsync_WhenSuccess_ReturnsUserDTOList(List<User> users)
        {
            //Arrange
            var userEntityList = users;

            _userRepository
                .Setup(repo => repo.GetListAsync())
                .ReturnsAsync(userEntityList);

            //Act
            var result = await _userService.GetUsersAsync();

            //Assert
            Assert.Equal(users.Count, result.Count);
        }

        [Theory]
        [AutoData]
        public void GetUserAsync_WhenSuccess_ReturnsUserDTOList(int userid)
        {
            //Act
            var result = _userService.GetUser(userid);

            //Assert
            Assert.NotNull(result);
        }
    }
}
