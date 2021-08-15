namespace Delegator.App.Services
{
    public class UserService : IUserService
    {
        private readonly Repository repository;

        public UserService(Repository repository) {
            this.repository = repository;
        }

        public void Save(User usr) {
        }

        public bool Validate(User usr) {
        }
    }
}
