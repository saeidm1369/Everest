using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleTitle { get; set; }
        public bool IsDelete { get; set; } = false;

        #region Relations for navigation property

        public ICollection<RoleUser> RoleUsers { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; }

        #endregion
    }
}
