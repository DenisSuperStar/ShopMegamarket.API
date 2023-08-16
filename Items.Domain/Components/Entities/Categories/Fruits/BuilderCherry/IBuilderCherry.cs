﻿using Items.Domain.Components.Entities.Categories.Fruits.Fruit;
using SelfCherry = Items.Domain.Components.Entities.Categories.Fruits.BuilderCherry.Cherry.Сherry;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderCherry
{
    public interface IBuilderCherry : IFruit
    {
        void SetPrice(int value);
        void SetImagePath(string value);
        void SetMaker(string value);
        void SetMinTemp(int value);
        void SetMaxTemp(int value);
        void SetProtein(float value);
        void SetFat(float value);
        void SetSugar(float value);
        void SetEnergy(float value);
        void SetCountInPackage(int value);
        void SetCreatedDate(int value);
        void SetFarmer(bool value);
        void SetWeight(float value);
        void SetCoolingMode(string value);
        SelfCherry CreateCherry();
    }
}
