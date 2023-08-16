﻿using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.Grocery.Pasta_and_cereals
{
    public class FastCook : Item
    {
        public string? Taste { get; set; }
        public int Weight { get; set; }
        public int EnergyValue { get; set; }
    }
}
