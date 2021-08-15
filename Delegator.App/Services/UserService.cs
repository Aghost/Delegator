using Delegator.Entities;

namespace Delegator.App.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository userRepository;

        public UserService(UserRepository userRepository) {
            this.userRepository = userRepository;
        }

        public void Save(User usr) {
        }

        public bool Validate(User usr) {
            return false;
        }
    }
}
