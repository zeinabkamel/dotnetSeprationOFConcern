using AutoMapper;
using Z.DTO;
using Z.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z.Mapping
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        ViewModelToDomainMappingProfile()
        {
         CreateMap<GadgetFormViewModel, Gadget>()
                .ForMember(g => g.Name, map => map.MapFrom(vm => vm.GadgetTitle))
                .ForMember(g => g.Description, map => map.MapFrom(vm => vm.GadgetDescription))
                .ForMember(g => g.Price, map => map.MapFrom(vm => vm.GadgetPrice))
                 .ForMember(g => g.CategoryID, map => map.MapFrom(vm => vm.GadgetCategory));
        }
    }
}