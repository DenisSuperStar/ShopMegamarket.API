﻿using Items.Domain.Components.Entities.Categories.Common;
using Items.Domain.Components.Entities.Categories.MilkProducts.Common;

namespace Items.Domain.Components.Entities.Categories.Drinks.ConcreteSoyMilk.SoyMilk
{
    public class SoyMilk : Drink
    {
        public string? KindOfMilk { get; set; }

        public SoyMilk(
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
            string kindOfMilk
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
            KindOfMilk = kindOfMilk;
        }
    }
}
