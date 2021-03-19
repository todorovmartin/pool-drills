namespace PoolDrills.Web.Services.Contracts
{
    using System.Collections.Generic;

    using PoolDrills.Data.Models;

    public interface IDrillsService
    {
        Drill GetDrillById(int id);

        void HideDrill(int id);

        void ShowDrill(int id);

        void DeleteDrill(int id);

        void ApproveDrill(int id);

        bool DrillExists(int id);

        bool EditDrill(Drill drill);

        IEnumerable<Drill> GetAllDrills();

        IEnumerable<Drill> GetAllDrillsByCategory(int categoryId);

        IEnumerable<Drill> GetAllDrillsByAuthor(string authorId);

        IEnumerable<Drill> GetAllHiddenDrills();

        IEnumerable<Drill> GetAllApprovedDrills();

        IEnumerable<Drill> GetAllDrillsBySearch(string searchString);
    }
}
