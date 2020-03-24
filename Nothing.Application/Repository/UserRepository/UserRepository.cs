using Nothing.Application.Repository.GenericRepository;
using Nothing.Model.Data;
using Nothing.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nothing.Application.Repository.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(NothingDBContext context) : base(context)
        { }

        private NothingDBContext _appContext => (NothingDBContext)_context;
    }
}
