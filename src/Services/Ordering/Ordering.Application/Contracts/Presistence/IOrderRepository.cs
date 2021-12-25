using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ordering.Domain.Common.Entities;

namespace Ordering.Application.Contracts.Presistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}
