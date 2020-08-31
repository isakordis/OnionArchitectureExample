using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Services
{
    public interface IUserServices
    {
        IEnumerable<User> GetUsers();
        User GetUser(long id);

        void insertUser(User user);
        void DeleteUser(long id);
        void UpdateUser(User user);


    }
}
