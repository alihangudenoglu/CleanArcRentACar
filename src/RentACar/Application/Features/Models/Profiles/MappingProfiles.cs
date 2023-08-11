using Application.Features.Models.Queries.GetList;
using Application.Features.Models.Queries.GetListByDynamic;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Model,GetListModelListItemDto>()
                .ForMember(x => x.BrandName,memberOptions:opt=>opt.MapFrom(c=>c.Brand.Name))
                .ForMember(x => x.FuelName, memberOptions: opt => opt.MapFrom(c => c.Fuel.Name))
                .ForMember(x => x.TransmissionName, memberOptions: opt => opt.MapFrom(c => c.Transmission.Name))
                .ReverseMap();
            CreateMap<Model, GetListByDynamicModelListItemDto>()
                .ForMember(x => x.BrandName, memberOptions: opt => opt.MapFrom(c => c.Brand.Name))
                .ForMember(x => x.FuelName, memberOptions: opt => opt.MapFrom(c => c.Fuel.Name))
                .ForMember(x => x.TransmissionName, memberOptions: opt => opt.MapFrom(c => c.Transmission.Name))
                .ReverseMap();
            CreateMap<Paginate<Model>, GetListResponse<GetListModelListItemDto>>().ReverseMap();
            CreateMap<Paginate<Model>, GetListResponse<GetListByDynamicModelListItemDto>>().ReverseMap();

        }
    }
}
