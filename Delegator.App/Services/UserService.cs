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
            if (Validate(usr) == true) { userRepository.Add(user) }
        }

        public bool Validate(User usr) {
            if (usr == null || string.IsNullOrEmpty(usr.LastName) || string.IsNullOrEmpty(usr.EmailAddress))
                throw new ArgumentNullException();

            // if (repository.Users?.contains usr)
        }
    }
}
