using OA.Data;
using OA.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Services
{
    public class UserServices : IUserServices
    {

        private readonly IRepository<User> userRepo;
        private readonly IRepository<UserProfile> userProRepo;
        public UserServices(IRepository<User> userRepository,IRepository<UserProfile> userProfileRepository)
        {
            this.userRepo = userRepository;
            this.userProRepo = userProfileRepository;
        }
        public void DeleteUser(long id)
        {
            UserProfile userProfile = userProRepo.Get(id);
            userProRepo.Remove(userProfile);
            User user = userRepo.Get(id);
            userRepo.Delete(user);

        }

        public User GetUser(long id)
        {
            return userRepo.Get(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return userRepo.GetAll();
        }

        public void insertUser(User user)
        {
            userRepo.Insert(user);
        }

        public void UpdateUser(User user)
        {
            userRepo.Update(user);
        }
    }
}
