namespace PoolDrills.Web.Areas.Administration.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PoolDrills.Web.Services.Contracts;

    public class DrillsController : AdministrationController
    {
        private readonly IDrillsService drillsService;

        public DrillsController(IDrillsService drillsService)
        {
            this.drillsService = drillsService;
        }

        public IActionResult ToApprove()
        {
            var drills = this.drillsService.GetAllDisApprovedDrills();

            return this.View(drills);
        }

        [HttpPost]
        public IActionResult ToApprove(int drillId)
        {
            this.drillsService.ApproveDrill(drillId);

            return this.RedirectToAction(nameof(this.ToApprove));
        }
    }
}
