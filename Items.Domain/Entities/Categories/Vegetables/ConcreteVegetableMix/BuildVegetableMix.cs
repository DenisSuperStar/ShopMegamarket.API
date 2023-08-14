﻿using SelfVegetable = Items.Domain.Entities.Categories.Vegetables.Vegetable.Vegetable;
using SelfvegetableMix = Items.Domain.Entities.Categories.Vegetables.ConcreteVegetableMix.VegetableMix.VegetableMix;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteVegetableMix
{
    public class BuildVegetableMix : IBuilderVegetableMix
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
        public float Weight { get; private set; }
        public string CoolingMode { get; private set; } = string.Empty;
        public string Grade { get; private set; } = string.Empty;
        public bool IsSlicingShape { get; private set; }
        public List<SelfVegetable> Vegetables { get; private set; } = new();

        public BuildVegetableMix(Guid personId, int countInPackage, int createdDate, float weight) 
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

        public void AddVegetables(List<SelfVegetable> value) 
        {
            if (value.Count == 0) return;
            Vegetables = value;
        }

        public SelfvegetableMix CreateVegetableMix() {
            return new SelfvegetableMix(this);
        }
    }
}
