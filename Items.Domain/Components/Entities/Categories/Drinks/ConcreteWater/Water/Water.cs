﻿using Items.Domain.Components.Entities.Categories.Common;
using Items.Domain.Components.Entities.Categories.MilkProducts.Common;

namespace Items.Domain.Components.Entities.Categories.Drinks.ConcreteWater.Water
{
    public class Water : Drink
    {
        public bool IsSparkling { get; set; }
        public string? Purpose { get; set; }

        public Water(
            Guid personId,
            Guid itemId,
            string itemName,
            int price,
            string imagePath,
            string maker,
            int minTemp,
            int maxTemp,
            float protein,
            float fat,
            float sugar,
            float energy,
            int countInPackage,
            int createdDate,
            List<ProductTaste> tastes,
            List<SoldCapacity> capacities,
            bool isChilled,
            bool isSparkling,
            string purpose
        )
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
            Maker = maker;
            MinTemp = minTemp;
            MaxTemp = maxTemp;
            Protein = protein;
            Fat = fat;
            Sugar = sugar;
            Energy = energy;
            CountInPackage = countInPackage;
            CreatedDate = createdDate;
            Tastes = tastes;
            Capacities = capacities;
            IsChilled = isChilled;
            IsSparkling = isSparkling;
            Purpose = purpose;
        }
    }
}
