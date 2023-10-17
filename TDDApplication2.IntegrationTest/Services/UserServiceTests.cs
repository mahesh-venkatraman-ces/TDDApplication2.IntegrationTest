using AutoFixture.Xunit2;
using System.Linq.Expressions;

namespace TDDApplication2.IntegrationTest.Services
{
    public class UserServiceTests
    {        

        public UserServiceTests()
        {
            _userService = new UserService(_userRepository.Object);
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
            Assert.Equal(1, result.Count);
        }

        [Theory]
        [AutoData]
        public async Task GetUserAsync_WhenSuccess_ReturnsUserDTOList(int userid)
        {
            //Act
            var result = await _userService.GetUserAsync(userid);

            //Assert
            Assert.NotNull(result);
        }
    }
}
