// ReSharper disable VirtualMemberCallInConstructor
namespace PoolDrills.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Identity;
    using PoolDrills.Data.Common.Models;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.FavoriteDrills = new HashSet<FavoriteDrill>();
            this.Drills = new HashSet<Drill>();
            this.Collections = new HashSet<Collection>();
        }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        // Added by me
        public virtual ICollection<FavoriteDrill> FavoriteDrills { get; set; }

        public virtual ICollection<Collection> Collections { get; set; }

        public virtual ICollection<Drill> Drills { get; set; }
    }
}
