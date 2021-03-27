namespace PoolDrills.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
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
            return this.View();
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
