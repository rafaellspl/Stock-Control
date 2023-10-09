using Stock_Control_Domain.Entities;
using Stock_Control_Infrastructure.Interfaces;
using Stock_Control_Infrastructure.Repositories;
using Stock_Control_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Services.Services
{
    public class ProductCategoryService : BaseService<ProductCategory>, IProductCategoryService
    {
        private readonly IProductCategoryRepository _repository;
        public ProductCategoryService(ProductCategoryRepository repository) : base(repository) { }
    }
}
