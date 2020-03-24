using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nothing.Application.Repository.LanguageRepository;

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
            result.listModel = loadData();
            return PartialView(result);
        }



        public List<Language> loadData()
        {
            return _ILanguage.GetAll();
        }
        
        public IActionResult ShowPageAdd()
        {
            return PartialView("_LanguageAdd");
        }

        [HttpPost]
        public IActionResult Add(Language data)
        {
            var result = new ResultModel<Language>();
            try
            {
                _ILanguage.Add(data);
                if (_ILanguage.Save() > 0)
                {
                    result.listModel = loadData();
                    result.status = true;
                    result.mess = "Thành công";
                    return PartialView("_LanguageTable",result);
                }
                else
                {
                    result.status = false;
                    result.mess = "Thất bại";
                }
                return Json(result);
            }
            catch (Exception ex)
            {
                result.status = false;
                result.mess = ex.ToString();
                return Json(result);
            }
        }

        public IActionResult Update(int id)
        {
            var result = new ResultModel<Language>();
            try
            {
                var model = _ILanguage.Get(id);
                if (model == null)
                {
                    result.status = false;
                    result.mess = "Không tìm thấy đối tượng";
                    return Json(result);
                }
                else
                    return PartialView("_LanguageUpdate",model);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public IActionResult SubmitUpdate(Language data)
        {
            var result = new ResultModel<Language>();
            var modelDB = _ILanguage.Get(data.ID_Language);
            if (modelDB == null)
            {
                return Json(new ResultModel<Language>() { status = false, mess = "That bai" }) ;
            }
            modelDB.Key_Language = data.Key_Language;
            modelDB.Language_EN = data.Language_EN;
            modelDB.Language_VN = data.Language_VN;

            if (_ILanguage.Save() > 0)
            {
                result.listModel = loadData();
                result.status = true;
                result.mess = "Thành công";
                return PartialView("_LanguageTable", result);
            }

            return Json(new ResultModel<Language>() { status = false, mess = "That bai" });

        }
    }
}