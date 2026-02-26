using Domain.Entities.ETypes;
using Domain.Shared.Entities;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public ETypeProduct TypeProduct { get; set; }
        public decimal Value { get; set; }
        public string Ingredients { get; set; }
        public string Description { get; set; }
        // IMG
    }
}
