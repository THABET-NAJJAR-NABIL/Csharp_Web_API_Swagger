using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_Swagger.Contracts
{
    public static class ApiRoutes
    {
        public const string Rout = "api";
        public const string Version = "v1";
        public const string Base =  Rout + "/" + Version;

        public static class Posts
        {
            public const string GetAll = Base + "/posts";
            public const string Get = Base + "/posts/{postId}";
            public const string Create = Base + "/create";
        }

        public static class User
        {
            public const string GetAllUsers = Base + "/Users";
            public const string saveUser = Base + "/saveUser";
            public const string Get = Base + "/user/{postId}";
            public const string DeleteUser = Base + "/deleteUser";
        }
    }
}
