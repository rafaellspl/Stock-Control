using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            
        }
        public User(
            string userName, string password,
            string name, string email,
            string phone, Role role)
        {
            UserName = userName;
            Password = password;
            Name = name;
            Email = email;
            Phone = phone;
            RoleId = role.Id;
            Role = role;

            CreatedAt = DateTime.Now;
            Active = true;
            Create();
        }

        public void Modify(
            string? userName, string? password,
            string? name, string? email,
            string? phone, Role role)
        {
            UserName = userName ?? UserName;
            Password = password ?? Password;
            Name = name ?? Name;
            Email = email ?? Email;
            Phone = phone ?? Phone;

            Role = role ?? Role;
        }


        public int Id { get; private set; }

        #region [Login]
        public string UserName { get; private set; }
        public string Password { get; private set; }
        #endregion

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }

        #region [AcessRights]
        public int RoleId { get; private set; }
        public Role Role { get; private set; }
        #endregion

    }
}
