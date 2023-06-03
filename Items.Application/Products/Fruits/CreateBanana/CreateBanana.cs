﻿using MediatR;
using Range = Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Range;

namespace Items.Application.Products.Fruits.CreateBanana
{
    public class CreateBanana : IRequest<Guid>
    {
        public string? ItemName { get; set; }
        public string? Brand { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public string? Storage { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public string? CoolingMode { get; set; }
        public string? Shape { get; set; }
        public string? Contain { get; set; }
        public float? Weight { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public DateOnly BeforeDate { get; set; }
        public string? ShortName { get; set; }
        public string? Description { get; set; }
        public string? Composition { get; set; }
        public string? Package { get; set; }
        public string? Grade { get; set; }
        public List<Range> SaleWeights { get; set; } = new();
    }
}
