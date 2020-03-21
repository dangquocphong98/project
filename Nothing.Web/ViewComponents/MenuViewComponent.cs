using Microsoft.AspNetCore.Mvc;
using Nothing.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nothing.Web.ViewComponents
{
    [ViewComponent(Name = "Menu")]
    public class MenuViewComponent : ViewComponent
    {
        private readonly IMenuRepository _IMenu;

        public MenuViewComponent(IMenuRepository IMenu)
        {
            _IMenu = IMenu;
        }

        public IViewComponentResult Invoke()
        {
            var lsMenu = _IMenu.GetAll();
            return View(lsMenu);
        }
    }
}
