using Stock_Control_Domain.Context;
using Stock_Control_Domain.Entities;
using Stock_Control_Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Infrastructure.Repositories
{
    public class ProductCategoryRepository : BaseRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(StockContext context) : base(context) { }
    }
}
