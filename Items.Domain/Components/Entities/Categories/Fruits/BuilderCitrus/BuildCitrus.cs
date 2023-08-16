﻿using Items.Domain.Components.Entities.Categories.Fruits.Common;
using SelfCitrus = Items.Domain.Components.Entities.Categories.Fruits.BuilderCitrus.Citrus.Citrus;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderCitrus
{
    public class BuildCitrus : IBuilderCitrus
    {
        public Guid PersonId { get; private set; }
        public Guid ItemId { get; private set; }
        public int Price { get; private set; }
        public string ImagePath { get; private set; } = string.Empty;
        public string Maker { get; private set; } = string.Empty;
        public int MinTemp { get; private set; }
        public int MaxTemp { get; private set; }
        public float Protein { get; private set; }
        public float Fat { get; private set; }
        public float Sugar { get; private set; }
        public float Energy { get; private set; }
        public int CountInPackage { get; private set; }
        public int CreatedDate { get; private set; }
        public float? Weight { get; private set; }
        public string CoolingMode { get; private set; } = string.Empty;
        public string Grade { get; private set; } = string.Empty;
        public bool IsSlicingShape { get; private set; }
        public string Description { get; private set; } = string.Empty;
        public List<SalesLine> SaleWeights { get; private set; } = new();

        public BuildCitrus(Guid personId, int countInPackage, int createdDate, float weight)
        {
            PersonId = personId;
            CountInPackage = countInPackage;
            CreatedDate = createdDate;
            Weight = weight;
        }

        public void SetPrice(int value) 
        {
            if (value <= 0) return;
            Price = value;
        }

        public void SetImagePath(string value)
        {
            if (string.IsNullOrEmpty(value)) return;
            ImagePath = value;
        }

        public void SetMaker(string value)
        {
            if (string.IsNullOrEmpty(value)) return;
            Maker = value;
        }

        public void SetMinTemp(int value)
        {
            if (value <= 0) return;
            MinTemp = value;
        }

        public void SetMaxTemp(int value)
        {
            if (value <= 0) return;
            MaxTemp = value;
        }

        public void SetProtein(float value)
        {
            if (value <= 0) return;
            Protein = value;
        }

        public void SetFat(float value)
        {
            if (value <= 0) return;
            Fat = value;
        }

        public void SetSugar(float value)
        {
            if (value <= 0) return;
            Sugar = value;
        }

        public void SetEnergy(float value)
        {
            if (value <= 0) return;
            Energy = value;
        }

        public void SetCountInPackage(int value)
        {
            if (value <= 0) return;
            CountInPackage = value;
        }

        public void SetCreatedDate(int value)
        {
            if (value <= 0) return;
            CreatedDate = value;
        }

        public void SetWeight(float value)
        {
            if (value <= 0) return;
            Weight = value;
        }

        public void SetCoolingMode(string value)
        {
            if (string.IsNullOrEmpty(value)) return;
            CoolingMode = value;
        }

        public void SetGrade(string value)
        {
            if (string.IsNullOrEmpty(value)) return;
            Grade = value;
        }

        public void SetSlicingShape(bool value)
        {
            if (!value) return;
            IsSlicingShape = value;
        }

        public void SetDescription(string value)
        {
            if (string.IsNullOrEmpty(value)) return;
            Description = value;
        }

        public void SetSalesWeights(List<SalesLine> value)
        {
            if (value.Count == 0) return;
            SaleWeights = value;
        }

        public SelfCitrus CreateCitrus()
        {
            return new SelfCitrus(this);
        }
    }
}
