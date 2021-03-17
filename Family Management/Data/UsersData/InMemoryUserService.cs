using System;
using System.Collections.Generic;
using System.Linq;
using Family_Management.Models;

namespace Family_Management.Data.UsersData
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    City = "Pokhara",
                    Domain = "via.dk",
                    Password = "123456",
                    Role = "Student",
                    BirthYear = 2000,
                    Securitylevel = 2,
                    UserName = "Satish"
                },
                new User
                {
                    City = "Chitwan",
                    Domain = "via.dk",
                    Password = "7891011",
                    Role = "Teacher",
                    BirthYear = 1998,
                    Securitylevel = 4,
                    UserName = "Troels"
                },
            }.ToList();
        }
        

        public User ValidateUser(string username, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(username));
            if (first==null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect Password");
            }

            return first;
        }
    }
    }
