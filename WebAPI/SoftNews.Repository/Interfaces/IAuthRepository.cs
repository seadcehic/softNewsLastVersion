﻿using SoftNews.Data.Model;
using System.Threading.Tasks;

namespace SoftNews.Repository.Interfaces
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
