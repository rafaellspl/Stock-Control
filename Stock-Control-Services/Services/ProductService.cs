using Stock_Control_Domain.Entities;
using Stock_Control_Infrastructure.Interfaces;
using Stock_Control_Infrastructure.Repositories;
using Stock_Control_Services.Interfaces;
using Stock_Control_Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Services.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(ProductRepository repository) : base(repository) { }

    }
}
