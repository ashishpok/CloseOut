using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloseOut.Model;
using CloseOut.Data;
using CloseOut.Data.Repositories;
using CloseOut.Data.Abstract;

namespace CloseOut.Data.Repositories
{
    public class UserRepository : EntityBaseRepository<User>, IUserRepository
    {
        public UserRepository(SchedulerContext context)
            : base(context)
        { }
    }
}
