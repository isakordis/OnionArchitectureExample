using OA.Data;
using OA.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Services
{
    public class UserProfileServices:IUserProfileServices
    {
        private readonly IRepository<UserProfile> repository;
        public UserProfileServices(IRepository<UserProfile>userProfileRepository )
        {
            this.repository = userProfileRepository;
        }

        public UserProfile GetUserProfile(long id)
        {
            return repository.Get(id);
        }
    }
}
