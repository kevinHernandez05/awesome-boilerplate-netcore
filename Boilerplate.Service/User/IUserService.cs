using Boilerplate.Model.Entities;
using Boilerplate.Model.Entities.JWT;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boilerplate.Service.User
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<UserEntity> GetAll();
        UserEntity GetUserById(int id);

    }
}
