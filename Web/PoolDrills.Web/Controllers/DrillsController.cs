namespace PoolDrills.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using PoolDrills.Common;
    using PoolDrills.Data.Models;
    using PoolDrills.Web.Services.Contracts;
    using PoolDrills.Web.ViewModels.Drills;

    public class DrillsController : Controller
    {
        private readonly IDrillsService drillsService;
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;

        public DrillsController(IDrillsService drillsService, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            this.drillsService = drillsService;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public IActionResult All()
        {
            var drills = this.drillsService.GetAllDrills();
            var drillsList = new List<DrillViewModel>();

            foreach (var drill in drills)
            {
                var drillsvm = new DrillViewModel
                {
                    Id = drill.Id,
                    Category = drill.Category.ToString(),
                    Description = drill.Description,
                    Difficulty = drill.Difficulty.ToString(),
                    ImageUrl = drill.ImageUrl,
                    Title = drill.Title,
                    IsApproved = drill.IsApproved,
                    IsHidden = drill.IsHidden,
                    Author = drill.Author,
                    AuthorId = drill.AuthorId,
                };
                drillsList.Add(drillsvm);
            }

            var vm = new AllDrillsViewModel
            {
                Drills = drillsList,
            };

            return this.View(vm);
        }

        [Authorize]
        public IActionResult Add()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(AddDrillViewModel model)
        {
            var drill = this.mapper.Map<Drill>(model);

            drill.AuthorId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            drill.Author = await this.userManager.GetUserAsync(this.User);

            if (!this.User.IsInRole(GlobalConstants.AdministratorRoleName))
            {
                drill.IsApproved = false;
            }

            this.drillsService.AddDrill(drill);

            return this.RedirectToAction(nameof(this.All)); // todo redirect to confrimation page
        }
    }
}
