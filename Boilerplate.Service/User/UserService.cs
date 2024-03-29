﻿using Boilerplate.Model.Entities;
using Boilerplate.Model.Entities.JWT;
using Boilerplate.Service.Helpers.jwt;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Boilerplate.Service.User
{
    public class UserService : IUserService
    {
        private List<UserEntity> _users = new List<UserEntity>
        {
            new UserEntity { Id = 1, FirstName = "Test", LastName = "User", Username = "test", Password = "test" },
        };

        public readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        public IEnumerable<UserEntity> GetAll()
        {
            return _users;
        }

        public UserEntity GetUserById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }

        // helper methods
        private string generateJwtToken(UserEntity user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();

            //if (String.IsNullOrEmpty(_appSettings.Secret))
            //{
            //    _appSettings.Secret = "PROBANDO";
            //}

            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
