namespace PoolDrills.Web.ViewModels.Drills
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AllDrillsViewModel
    {
        public IEnumerable<DrillViewModel> Drills { get; set; }

        public int CurrentPage { get; set; }

        public int PagesCount { get; set; }

        public int NewsCount { get; set; }

        public int PreviousPage => this.CurrentPage == 1 ? 1 : this.CurrentPage - 1;

        public int NextPage => this.CurrentPage == this.PagesCount ? this.PagesCount : this.CurrentPage + 1;

        public string Search { get; set; }
    }
}
