using Stock_Control_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Infrastructure.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
    }
}
