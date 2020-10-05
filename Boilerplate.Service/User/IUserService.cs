using Boilerplate.Model.Entities;
using Boilerplate.Model.Entities.JWT;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boilerplate.Service
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetUserById(int id);

    }
}
