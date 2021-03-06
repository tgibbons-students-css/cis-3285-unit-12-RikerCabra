﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public class UserRepository : IEntityRepository<User>
    {
        public virtual User GetByID(Guid id)
        {
            return new User(id);
        }
    }
}
