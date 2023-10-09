using Org.BouncyCastle.Bcpg.OpenPgp;
using Stock_Control_Domain.Entities.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Domain.Entities
{
    public class BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public bool Active { get; set; }

        public void Create()
        {
            CreatedAt = DateTime.Now;
            Active = true;
        }

        public void Delete()
        {
            DeletedAt = DateTime.Now;
            Active = false;
        }
    }
}
