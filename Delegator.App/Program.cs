using System;
using System.Collections.Generic;
using Delegator.Entities;
using Delegator.Lib;
//using Microsoft.EntityFrameworkCore;

using static System.Console;

namespace Delegator.App
{
    class Program {
        static void Main(string[] args) {
            WriteLine("test");

            // Configure services? dbcontext???
            //var userRepository = new UserRepository(InMemoryDb);

            var InMemoryDb = new List<User>() {
                new(1, "Henk", "Henksen", "HenkHenksen@henk.henk"),
                new(2, "Klaas", "Klaassen", "KlaasKlaassen@klaas.klaas")
            };

            foreach (User user in InMemoryDb) {
                WriteLine(user.Test());
            }

        }
    }
}
