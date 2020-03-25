using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Nothing.Application.Repository.UserRepository;
using Nothing.Model.Entity;
using Nothing.Web.Common;

namespace Nothing.Web.Controllers
{
    public class LoginController : Controller
    {
        IUserRepository _IUser;

        public LoginController(IUserRepository IUser)
        {
            _IUser = IUser;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult SubmitLogin(string username, string password)
        {
            var result = new ResultModel<User>();
            var lsmodel = _IUser.GetAll();
            var model = lsmodel.FirstOrDefault(x=>x.IsDelete == true && x.UserName == username);
            if (model == null)
            {
                result.status = false;
                result.mess = "Sai tai khoan hoac mat khau";
            }
            else
            {
                result.status = true;
                result.mess = "Dang nhap thanh cong";

                Response.Cookies.Append("ss","ss");

                HttpContext.Session.SetString("UserCurrent",JsonConvert.SerializeObject(model));
                HttpContext.Session.SetString("LanguageCurrent",model.LanguageCurrent);
            }
            return new JsonResult(result);

        }
    }
}