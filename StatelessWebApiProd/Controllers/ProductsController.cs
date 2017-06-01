using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using SelfHostedWebApi.Models;

namespace SelfHostedWebApi.Controllers
{
  public class ProductsController : ApiController
  {
    public IEnumerable<Product> GetProducts() {
      return Repository.Current.Products;
    }
    public Product GetProduct(int id) {
      return Repository.Current.Products.FirstOrDefault(p => p.ProductID == id);
    }
    public Product PostProduct(Product product) {
      return Repository.Current.SaveProduct(product);
    }
    public Product DeleteProduct(int id) {
      return Repository.Current.DeleteProduct(id);
    }
  }
}
