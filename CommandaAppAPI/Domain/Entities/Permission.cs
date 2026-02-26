using Domain.Entities.ETypes;
using Domain.Shared.Entities;

namespace Domain.Entities
{
    public class Permission : BaseEntity
    {
        public string Name { get; set; }
        public ETypeScope TypeScope { get; set; }
        public ETypeProcedure TypeProcedure { get; set; }
    }
}
