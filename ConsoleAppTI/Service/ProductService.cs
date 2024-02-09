using ConsoleAppTI.Dtos;
using ConsoleAppTI.Entities;
using ConsoleAppTI.Repositories;
using System.Diagnostics;

namespace ConsoleAppTI.Service;

public class ProductService(CustomerRepository customerRepository, OrderRepository orderRepository, OrderRowRepository orderRowRepository, PriceRepository priceRepository, ProductRepository productRepository)
{
    private readonly CustomerRepository _customerRepository = customerRepository;
    private readonly OrderRepository _orderRepository = orderRepository;
    private readonly OrderRowRepository _orderRowRepository = orderRowRepository;
    private readonly PriceRepository _priceRepository = priceRepository;
    private readonly ProductRepository _productRepository = productRepository;

    public bool CreateProduct(Product product)
    {
        try
        {
            if (!_productRepository.Exists(x => x.ProductId == product.ProductId))
            {
                var priceEntity = _priceRepository.GetOne(x => x.Price == product.Price);
                priceEntity ??= _priceRepository.Create(new PriceEntity { Price = product.Price });

                var productEntity = new ProductEntity
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    PriceId = priceEntity.PriceId
                };

                var result = _productRepository.Create(productEntity);
                if (result != null)
                    return true;

            }
        }
        catch (Exception ex) { Debug.WriteLine("ERROR :: " + ex.Message); }

        return false;
    }

    public IEnumerable<Product> GetAllProducts()
    {

        var products = new List<Product>();
        try
        {
            var result = _productRepository.GetAll();


            foreach (var item in result)
                products.Add(new Product
                {
                    ProductId = item.ProductId,
                    ProductName = item.ProductName,
                    PriceId = item.PriceId
                });
        }
        catch (Exception ex) { Debug.WriteLine("ERROR :: " + ex.Message); }

        return products;
    }
}
