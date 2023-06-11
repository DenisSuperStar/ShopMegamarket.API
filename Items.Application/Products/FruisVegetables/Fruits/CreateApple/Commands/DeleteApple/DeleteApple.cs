﻿using MediatR;

namespace Items.Application.Products.FruisVegetables.Fruits.CreateApple.Commands.DeleteApple
{
    public class DeleteApple : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
