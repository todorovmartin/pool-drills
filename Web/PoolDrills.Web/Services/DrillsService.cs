namespace PoolDrills.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.AspNetCore.Identity;
    using PoolDrills.Data;
    using PoolDrills.Data.Models;
    using PoolDrills.Data.Models.Enums;
    using PoolDrills.Web.Services.Contracts;

    public class DrillsService : IDrillsService
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;

        public DrillsService(
            ApplicationDbContext db,
            UserManager<ApplicationUser> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }

        public void AddDrill(Drill drill)
        {
            if (drill == null)
            {
                return;
            }

            this.db.Drills.Add(drill);
            this.db.SaveChanges();
        }

        public bool ApproveDrill(int id)
        {
            var drill = this.db.Drills.FirstOrDefault(x => x.Id == id);
            if (drill == null)
            {
                return false;
            }

            drill.IsApproved = true;
            this.db.SaveChanges();
            return true;
        }

        public void DeleteDrill(int id)
        {
            var drill = this.GetDrillById(id);

            if (drill == null)
            {
                return;
            }

            this.db.Drills.Remove(drill);
            this.db.SaveChanges();
        }

        public bool DrillExists(int id)
        {
            return this.db.Drills.Any(x => x.Id == id);
        }

        public bool EditDrill(Drill drill)
        {
            if (!this.DrillExists(drill.Id))
            {
                return false;
            }

            try
            {
                this.db.Update(drill);
                this.db.SaveChanges();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public IEnumerable<Drill> GetAllApprovedDrills()
        {
            return this.db.Drills.Where(x => x.IsApproved == true).ToList();
        }

        public IEnumerable<Drill> GetAllDrills()
        {
            return this.db.Drills.ToList();
        }

        public IEnumerable<Drill> GetAllDrillsByAuthor(string authorId)
        {
            return this.db.Drills.Where(x => x.AuthorId == authorId).ToList();
        }

        public IEnumerable<Drill> GetAllDrillsByCategory(Category category)
        {
            return this.db.Drills.Where(x => x.Category == category).ToList();
        }

        public IEnumerable<Drill> GetAllDrillsBySearch(string searchString)
        {
            var searchStringClean = searchString.Split(new string[] { ",", ".", " " }, StringSplitOptions.RemoveEmptyEntries);

            IQueryable<Drill> products = this.db.Drills.Where(x => x.Title.ToLower().Contains(searchString.ToLower())
                                                                 || x.Description.ToLower().Contains(searchString.ToLower()));
            return products;
        }

        public IEnumerable<Drill> GetAllVisibleDrills()
        {
            return this.db.Drills.Where(x => x.IsHidden == false).ToList();
        }

        public Drill GetDrillById(int id)
        {
            var drill = this.db.Drills.FirstOrDefault(x => x.Id == id);

            return drill;
        }

        public bool HideDrill(int id)
        {
            var drill = this.db.Drills.FirstOrDefault(x => x.Id == id);
            if (drill == null)
            {
                return false;
            }

            drill.IsHidden = true;
            this.db.SaveChanges();
            return true;
        }

        public bool ShowDrill(int id)
        {
            var drill = this.db.Drills.FirstOrDefault(x => x.Id == id);
            if (drill == null)
            {
                return false;
            }

            drill.IsHidden = false;
            this.db.SaveChanges();
            return true;
        }
    }
}
