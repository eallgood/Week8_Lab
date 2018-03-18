﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8_Lab.Data.Entities;

namespace Week8_Lab.Repositories
{
    public interface IUserRepo
    {
        User GetUser(int id);

        IEnumerable<User> GetAllUsers();

        void SaveUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int id);
    }
}
