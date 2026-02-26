using Domain.Entities.ETypes;
using Domain.Shared.Entities;

namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Name { get; set; }
        public string? Table { get; set; }
        public ETypeOrderStatus TypeOrderStatus { get; set; }
        public ETypePaymentStatus TypePaymentStatus { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
        public Guid UserId { get; set; }
    }
}
