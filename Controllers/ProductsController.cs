using System.Collections.Generic;
using Asp.NetCoreMySecondApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMySecondApi.Controllers
{

    //<summary>
    //{Controller}/{Action}/{Id?}
    //<summary>

    [Route("api/Products")]
    public class ProductsController: ControllerBase
    {
        private List<Product> _products = new List<Product>{

            new Product{

                ProductId = 1,
                Name = "Huawei Y9",
                Description = "Telefono de la marca Huawei ultimo modelo, en estado perfecto",
                Price = 17000
            }



        };

        [HttpGet]
        public List<Product> GetProducts() => _products;
        

        //<summary>
        //Get: Products/Home
        //</summary>

        /* [HttpGet]
        public string Home() => "Hello World"; */
    }
}