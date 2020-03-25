using Microsoft.AspNetCore.Http;
using Nothing.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nothing.Web.Common
{
    public  class GetLab
    {
        static ILanguageRepository _ILang;

        private  readonly IHttpContextAccessor _httpContextAccessor;
        private  readonly ISession _session;
        public GetLab(IHttpContextAccessor httpContextAccessor, ILanguageRepository ILang)
        {
            _httpContextAccessor = httpContextAccessor;
            _session = _httpContextAccessor.HttpContext.Session;
            _ILang = ILang;
        }

        public string GetLang(string key)
        {
           
            var lsModel = _ILang.GetAll();
            var model = lsModel.FirstOrDefault(x=>x.Key_Language == key);
            var Language = _httpContextAccessor.HttpContext.Session.GetString("LanguageCurrent");
            if (Language == "VN")
            {
                return model.Language_VN;
            }
            else
                return model.Language_EN;
        }
    }
}
