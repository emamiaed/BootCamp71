using Exam2.Entities;

namespace Exam2.DAL
{
    public interface IRepository
    {
        
        void AddProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);
        Product GetProductDetail(int id);
        List<Product> GetAllProducts();
        List<Category> GetAllCategories();

    }
}
