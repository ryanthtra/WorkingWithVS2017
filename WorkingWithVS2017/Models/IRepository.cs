using System.Collections.Generic;

namespace WorkingWithVS2017.Models
{


  public interface IRepository
  {
    IEnumerable<Product> Products { get; }
    void AddProduct(Product p);
  }
}
