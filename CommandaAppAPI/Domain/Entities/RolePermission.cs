using Domain.Shared.Entities;

namespace Domain.Entities
{
    public class RolePermission : BaseEntity
    {
        #region Relationships
        public Role Role { get; set; }
        public Permission Permission { get; set; }
        #endregion

        public Guid RoleId { get; set; }
        public Guid PermissionId { get; set; }
    }
}
