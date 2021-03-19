namespace PoolDrills.Web.Services.Contracts
{
    using System.Collections.Generic;

    using PoolDrills.Data.Models;
    using PoolDrills.Data.Models.Enums;

    public interface IDrillsService
    {
        Drill GetDrillById(int id);

        bool HideDrill(int id);

        bool ShowDrill(int id);

        void DeleteDrill(int id);

        bool ApproveDrill(int id);

        bool DrillExists(int id);

        bool EditDrill(Drill drill);

        void AddDrill(Drill drill);

        IEnumerable<Drill> GetAllDrills();

        IEnumerable<Drill> GetAllDrillsByCategory(Category category);

        IEnumerable<Drill> GetAllDrillsByAuthor(string authorId);

        IEnumerable<Drill> GetAllVisibleDrills();

        IEnumerable<Drill> GetAllApprovedDrills();

        IEnumerable<Drill> GetAllDrillsBySearch(string searchString);
    }
}
