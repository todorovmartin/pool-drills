namespace PoolDrills.Web.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.EntityFrameworkCore;
    using PoolDrills.Data;
    using PoolDrills.Data.Models;
    using PoolDrills.Web.Services.Contracts;

    public class FavoritesService : IFavoritesService
    {
        private readonly ApplicationDbContext db;

        public FavoritesService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public bool Add(int id, string username)
        {
            var user = this.db.Users.Include(x => x.FavoriteDrills).FirstOrDefault(x => x.UserName == username);
            if (user == null || user.FavoriteDrills.Any(x => x.DrillId == id))
            {
                return false;
            }

            var drillExists = this.db.Drills.Any(x => x.Id == id);
            if (drillExists)
            {
                return false;
            }

            var favoritesDrill = new FavoriteDrill
            {
                DrillId = id,
                UserId = user.Id,
            };

            user.FavoriteDrills.Add(favoritesDrill);
            this.db.SaveChanges();

            return true;
        }

        public IEnumerable<FavoriteDrill> All(string username)
        {
            var userFavorites = this.db.FavoriteDrills.Include(x => x.Drill).Where(x => x.User.UserName == username);

            if (userFavorites == null)
            {
                return new List<FavoriteDrill>();
            }

            return userFavorites;
        }

        public void Remove(int id, string username)
        {
            var favoriteProduct = this.db.FavoriteDrills.FirstOrDefault(x => x.User.UserName == username && x.DrillId == id);
            if (favoriteProduct == null)
            {
                return;
            }

            this.db.FavoriteDrills.Remove(favoriteProduct);
            this.db.SaveChanges();
        }
    }
}
