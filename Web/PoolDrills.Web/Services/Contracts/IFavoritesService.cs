namespace PoolDrills.Web.Services.Contracts
{
    using System.Collections.Generic;

    using PoolDrills.Data.Models;

    public interface IFavoritesService
    {
        bool Add(int id, string username);

        IEnumerable<FavoriteDrill> All(string username);

        void Remove(int id, string username);
    }
}
