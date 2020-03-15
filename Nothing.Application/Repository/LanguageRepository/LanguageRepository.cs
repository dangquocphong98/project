using Microsoft.EntityFrameworkCore;
using Nothing.Application.Repository.GenericRepository;
using Nothing.Model.Data;
using Nothing.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nothing.Application.Repository.LanguageRepository
{
    public class LanguageRepository : GenericRepository<Language> ,ILanguageRepository 
    {
        public LanguageRepository(NothingDBContext context) : base(context)
        { }

        private NothingDBContext _appContext => (NothingDBContext)_context;
    }
}
