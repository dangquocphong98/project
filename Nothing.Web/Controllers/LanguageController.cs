using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nothing.Application.Repository.LanguageRepository;
using Nothing.Application.Service;
using Nothing.Model.Entity;
using Nothing.Web.Common;

namespace Nothing.Web.Controllers
{
    public class LanguageController : Controller
    {
         private ILanguageRepository _ILanguage;
        //private readonly LanguageService serviceLanguage;

        public LanguageController(ILanguageRepository ILanguage)
        {
            // _ILanguage = new LanguageRepository();
            _ILanguage = ILanguage;
        }
        public IActionResult Index()
        {
            var result = new ResultModel<Language>();
            var listLanguage = _ILanguage.GetAll();
          result.listModel = listLanguage;
            return PartialView(result);
        }
    }
}