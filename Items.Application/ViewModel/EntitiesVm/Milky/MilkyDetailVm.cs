﻿using AutoMapper;
using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Entities.Milk;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.EntitiesVm.Milky
{
    public class MilkyDetailVm : IMapWith<Milk>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public List<FatContentProduct> FatContents { get; set; } = new();
        public string? Maker { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CreatedDate { get; set; }
        public float Volume { get; set; }
        public string? Description { get; set; }
        public bool IsLactoFree { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Milk, MilkyDetailVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.MinTemp,
                    opt => opt.MapFrom(map => map.MinTemp))
                .ForMember(map => map.MaxTemp,
                    opt => opt.MapFrom(map => map.MaxTemp))
                .ForMember(map => map.FatContents,
                    opt => opt.MapFrom(map => map.FatContents))
                .ForMember(map => map.Maker,
                    opt => opt.MapFrom(map => map.Maker))
                .ForMember(map => map.Protein,
                    opt => opt.MapFrom(map => map.Protein))
                .ForMember(map => map.Fat,
                    opt => opt.MapFrom(map => map.Fat))
                .ForMember(map => map.Sugar,
                    opt => opt.MapFrom(map => map.Sugar))
                .ForMember(map => map.Energy,
                    opt => opt.MapFrom(map => map.Energy))
                .ForMember(map => map.CreatedDate,
                    opt => opt.MapFrom(map => map.CreatedDate))
                .ForMember(map => map.Volume,
                    opt => opt.MapFrom(map => map.Volume))
                .ForMember(map => map.Description,
                    opt => opt.MapFrom(map => map.Description))
                .ForMember(map => map.IsLactoFree,
                    opt => opt.MapFrom(map => map.IsLactoFree));
        }
    }
}
