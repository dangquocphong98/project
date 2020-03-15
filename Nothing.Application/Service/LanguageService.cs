using Microsoft.EntityFrameworkCore;
using Nothing.Model.Data;
using Nothing.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nothing.Application.Service
{
    public class LanguageService
    {
        private readonly NothingDBContext db;

        public LanguageService(NothingDBContext _db)
        {
            db = _db;
        }
        public List<Language> getall()
        {
            var model = db.languages.ToList();
            return model;
        }
        //ILanguageRepository _ILang
    }
}
