using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Domain.Entities
{
    public class ProductCategory : BaseEntity
    {
        public ProductCategory()
        {
            
        }
        public ProductCategory(string categoryName, List<Product> products, List<ProductCategory>? subCategories)
        {
            CategoryName = categoryName;
            if (subCategories != null)
            {
                SubCategories = new List<ProductCategory>();
                SubCategories.AddRange(subCategories);
            }
            else
            {
                ProductList = new List<Product>();
                ProductList.AddRange(products);
            }
            Create();

        }

        public int Id { get; private set; }
        public string CategoryName { get; private set; }

        public List<ProductCategory>? SubCategories { get; private set; }

        public int? ParentCategoryId { get; private set; }
        public ProductCategory? ParentCategory { get; private set; }
        public List<Product>? ProductList { get; set; }
    }
}
