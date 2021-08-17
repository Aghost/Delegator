using System;
using Moq;
using Xunit;

namespace Delegator.Test
{
    public class Save
    {
        private Mock<IRepository> mock;
        private UserService userService;

        public Save() {
            mock = new Mock<IRepository>();
            userService = new UserService(mock.Object);
        }

        [Fact]
        public void Throw_NullException_WhenUserIsNull() {
            // Arrange
            /*
            var mockRepo = new Mock<Repository>();
            var mockService = new UserService<mockRepo.Object);

            // Assert
            Assert.Throws<ArgumentNullException>(() => mockUserService.Save(null));
            */
        }

        [Fact]
        public void Throw_NullException_whenLastNameIsNullOrEmpty(string lastname) {
            User user = new () { LastName = lastname }

            // Assert
            Assert.Throws<ArgumentNullException>(() => mockUserService.Save(null));
        }

        [Theory]
        [InlineData("ABCD@henk.henk")]
        [InlineData("henk@henk.henk")]
        public void ReturnTrueWhenUserCorrect(string email) {
            // Arrange
            User user = new() { LastName = "ln", EmailAddress = email, FirstName "henk" };

            // Act
            userService.Save(user);

            //Assert
            Assert.True(userService.Validate(user));
        }

        /*
        [Theory]
        [InlineData("henk@henk")]
        [InlineData("henk")]
        [InlineData("")]
        public void Throw_NullException_(string email) {
        }
        */
    }
}
