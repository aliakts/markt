using System;
using System.Threading.Tasks;
using markt.Entities;
using markt.Repository;

namespace markt.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Product> ProductRepository { get; }
        IGenericRepository<OrderItems> OrderItemsRepository { get; }
        IGenericRepository<Order> OrderRepository { get; }
        Task Commit();
    }
}