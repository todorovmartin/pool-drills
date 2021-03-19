namespace PoolDrills.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using PoolDrills.Data;
    using PoolDrills.Data.Models;
    using PoolDrills.Web.Services.Contracts;

    public class DrillsService : IDrillsService
    {
        private readonly ApplicationDbContext db;

        public DrillsService(
            ApplicationDbContext db)
        {
            this.db = db;
        }

        public void ApproveDrill(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteDrill(int id)
        {
            throw new NotImplementedException();
        }

        public bool DrillExists(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditDrill(Drill drill)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Drill> GetAllApprovedDrills()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Drill> GetAllDrills()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Drill> GetAllDrillsByAuthor(string authorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Drill> GetAllDrillsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Drill> GetAllDrillsBySearch(string searchString)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Drill> GetAllHiddenDrills()
        {
            throw new NotImplementedException();
        }

        public Drill GetDrillById(int id)
        {
            throw new NotImplementedException();
        }

        public void HideDrill(int id)
        {
            throw new NotImplementedException();
        }

        public void ShowDrill(int id)
        {
            throw new NotImplementedException();
        }
    }
}
