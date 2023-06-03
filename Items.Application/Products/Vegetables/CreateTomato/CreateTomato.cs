﻿using MediatR;

namespace Items.Application.Products.Vegetables.CreateTomato
{
    public class CreateTomato : IRequest<Guid>
    {
        public string? ItemName { get; set; }
        public string? Brand { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int Maxtemp { get; set; }
        public float? Weight { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public DateOnly BeforeDate { get; set; }
        public string? ShortName { get; set; }
        public string? Grade { get; set; }
        public string? SkinColor { get; set; }
    }
}
