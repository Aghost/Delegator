using Delegator.Entities;

namespace Delegator.App.Services
{
    interface IUserService
    {
        void Save(User user);
        bool Validate(User user);
    }
}
