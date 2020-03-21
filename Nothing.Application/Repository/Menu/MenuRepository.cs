using Nothing.Application.Repository.GenericRepository;
using Nothing.Model.Data;
using Nothing.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nothing.Application.Repository.Menu
{
    public class MenuRepository : GenericRepository<MenuAdmin>, IMenuRepository
    {
        public MenuRepository(NothingDBContext context) : base(context)
        { }

        private NothingDBContext _appContext => (NothingDBContext)_context;
    }
}
