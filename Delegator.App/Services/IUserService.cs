namespace Delegator.Services
{
    interface IUserService
    {
        void Save(User user);
        bool Validate(User user);
    }
}
