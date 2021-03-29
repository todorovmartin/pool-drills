namespace PoolDrills.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using PoolDrills.Data.Models;
    using PoolDrills.Web.Services.Contracts;
    using PoolDrills.Web.ViewModels.Drills;

    public class DrillsController : Controller
    {
        private readonly IDrillsService drillsService;
        private readonly IMapper mapper;

        public DrillsController(IDrillsService drillsService, IMapper mapper)
        {
            this.drillsService = drillsService;
            this.mapper = mapper;
        }

        public IActionResult All()
        {
            var drills = this.drillsService.GetAllDrills();

            return this.View(drills);
        }

        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Add(AddDrillViewModel model)
        {
            var drill = this.mapper.Map<Drill>(model);

            this.drillsService.AddDrill(drill);

            return this.RedirectToAction(nameof(this.All)); // todo redirect to confrimation page
        }
    }
}
