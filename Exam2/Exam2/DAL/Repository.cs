using Exam2.Entities;
using Exam2.Interfaces;

namespace Exam2.DAL
{
    public class Repository:IRepository
    {
        private readonly ProductDbContext _context = new ProductDbContext();

        void IRepository.AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        List<Product> IRepository.GetAllProducts()
        {
            return _context.Products.ToList();
        }
        List<Category> IRepository.GetAllCategories()
        {
            return _context.Categories.ToList();
        }


        Product IRepository.GetProductDetail(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }



        void IRepository.DeleteProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Remove(product);
            _context.SaveChanges();
        }




        void IRepository.UpdateProduct(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();

        }



    }
}
