using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Domain.Entities
{
    public class Product : BaseEntity
    {
        public Product()
        {
                
        }
        public Product(
            string productId, string productName, 
            string productBarCode, string productDescription,
            ProductCategory category)
        {
            ProductId = productId;
            ProductName = productName;
            ProductBarCode = productBarCode;
            ProductDescription = productDescription;

            CategoryId = category.Id;
            Category = category;
            Create();
        }

        public int Id { get; private set; }

        #region [Relations]
        public int CategoryId { get; private set; }
        public ProductCategory Category { get; private set; }
        #endregion
        public string ProductId { get; private set; }
        public string ProductName { get; private set; }
        public string ProductBarCode { get; private set; }
        public string ProductDescription { get; private set; }
    }
}
