using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Delegator.Entities
{
    public class UserRepository : IUserRepository {
        private ApplicationDbContext ctx;

        public UserRepository(ApplicationDbContext ctx) {
            this.ctx = ctx;
        }

        public IEnumerable<User> GetUsers() {
            return ctx.Users.ToList();
        }

        public User GetUserByID(int userId) {
            return ctx.Users.Find(userId);
        }

        public void InsertUser(User user) {
            ctx.Users.Add(user);
        }

        public void DeleteUser(int userId) {
            User user = ctx.Users.Find(userId);
            ctx.Users.Remove(user);
        }

        public void UpdateUser(User user) {
            ctx.Entry(user).State = EntityState.Modified;
        }

        public void Save() {
            ctx.SaveChanges();
        }
    }
}
