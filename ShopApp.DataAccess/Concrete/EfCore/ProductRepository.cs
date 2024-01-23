using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.DataContext;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public class ProductRepository : GenericRepository<Product, Context>, IProductRepository
    {
        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }
    }
}
