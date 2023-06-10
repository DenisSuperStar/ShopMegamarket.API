﻿namespace Items.Domain.Products.FreshItem.FruitsVegetables.Fruits
{
    public abstract class Fruit : Eat
    {
        public string? ShortName { get; set; }
        public string? Shape { get; set; }
        public string? Description { get; set; }
        public string? Composition { get; set; }
    }
}
