using MongoDB.Driver;
using UserApi.Models;
using System;
using System.Collections.Generic;

namespace UserApi.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase("UserDb");
            _users = database.GetCollection<User>("Users");
        }

        public List<User> GetUsers()
        {
            return _users.Find(user => true).ToList();
        }

        public void InsertUser(User user)
        {
            _users.InsertOne(user);
        }
    }
}

