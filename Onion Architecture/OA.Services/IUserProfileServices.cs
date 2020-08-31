using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Services
{
    public interface IUserProfileServices
    {
        UserProfile GetUserProfile(long id);

    }
}
