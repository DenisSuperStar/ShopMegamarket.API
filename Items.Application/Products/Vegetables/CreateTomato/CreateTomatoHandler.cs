﻿using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Vegetables;
using MediatR;

namespace Items.Application.Products.Vegetables.CreateTomato
{
    public class CreateTomatoHandler : IRequestHandler<CreateTomato, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateTomatoHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateTomato request, CancellationToken cancellationToken)
        {
            var tomato = new Tomato
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Brand = request.Brand,
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.Maxtemp,
                Weight = request.Weight,
                Capacities = null,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                ShortName = request.ShortName,
                Grade = request.Grade,
                SkinColor = request.SkinColor
            };

            await _dbContext.Tomatoes.AddAsync(tomato, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return tomato.ItemId;
        }
    }
}
