using Domain.Shared.Entities;

namespace Domain.Entities
{
    public class Observation : BaseEntity
    {
        #region Relationships
        public Product Product { get; set; }
        public Order Order { get; set; }
        #endregion

        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }
        public string Descrtiption { get; set; }
    }
}
