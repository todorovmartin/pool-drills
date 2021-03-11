namespace PoolDrills.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using PoolDrills.Web.ViewModels.Drills;

    public class DrillsController : Controller
    {
        public IActionResult All()
        {
            return View();
        }

        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Add(AddDrillViewModel model)
        {
            return this.View();
        }
    }
}
