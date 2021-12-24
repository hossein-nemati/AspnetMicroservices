using System;
using Ordering.Domain.Common.Entities;

namespace Ordering.Application.Contracts.Presistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}
