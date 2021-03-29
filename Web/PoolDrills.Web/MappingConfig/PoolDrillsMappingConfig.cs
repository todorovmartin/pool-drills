namespace PoolDrills.Web.MappingConfig
{
    using AutoMapper;
    using PoolDrills.Data.Models;
    using PoolDrills.Web.ViewModels.Drills;

    public class PoolDrillsMappingConfig : Profile
    {
        public PoolDrillsMappingConfig()
        {
            this.CreateMap<AddDrillViewModel, Drill>();
            this.CreateMap<EditDrillViewModel, Drill>();
            this.CreateMap<Drill, EditDrillViewModel>();
            this.CreateMap<Drill, DrillViewModel>();
        }
    }
}
