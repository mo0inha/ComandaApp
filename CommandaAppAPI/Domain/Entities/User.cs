using Domain.Shared.Entities;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        #region Relationships
        public Role Role { get; set; }
        #endregion

        public string Name { get; set; }
        public Guid RoleId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
