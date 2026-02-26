using Domain.Shared.Entities;

namespace Domain.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string Desciption { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
