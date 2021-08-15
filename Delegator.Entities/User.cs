using System;

namespace Delegator.Entities
{
    public class User
    {
        private readonly int Id;
        private readonly string FirstName;
        private readonly string LastName;
        private readonly string EmailAddress;

        public Predicate<string> isValid;

        public User(int Id, string FirstName, string LastName, string EmailAddress) {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
        }

        public string Test() {
            return $"{Id} {FirstName} {LastName} {EmailAddress}";
        }
    }
}
