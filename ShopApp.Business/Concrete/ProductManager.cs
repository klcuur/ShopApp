using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.EfCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _iProductRepository;
        public ProductManager(IProductRepository iProductRepository)
        {
            _iProductRepository=iProductRepository;
        }

        public void Create(Product entity)
        {
            _iProductRepository.Create(entity);

        }

        public void Delete(Product entity)
        {
           _iProductRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
           return _iProductRepository.GetAll().ToList();
        }

        public Product GetById(int id)
        {
            return _iProductRepository.GetById(id);
        }

        public void Update(Product entity)
        {
            _iProductRepository.Update(entity);
        }
    }
}
