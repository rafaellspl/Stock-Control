using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock_Control_Domain.Context;
using Stock_Control_Domain.Entities;
using Stock_Control_Infrastructure.Interfaces;

namespace Stock_Control_Infrastructure.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(StockContext context) : base(context)
        {

        }

    }
}
