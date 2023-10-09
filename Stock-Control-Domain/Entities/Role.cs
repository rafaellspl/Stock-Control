using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Domain.Entities
{
    public class Role
    {
        public Role()
        {
                
        }
        public int Id { get; private set; }
        public string RoleName { get; set; }

        public List<User> Users { get; private set; }
    }
}
