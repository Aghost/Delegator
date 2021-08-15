using System.Collections.Generic;

namespace Delegator.Entities
{
    public interface IUserRepository {
        IEnumerable<User> GetUsers();
        User GetUserByID(int userId);
        void InsertUser(User user);
        void DeleteUser(int userId);
        void UpdateUser(User user);
        void Save();
    }
}
