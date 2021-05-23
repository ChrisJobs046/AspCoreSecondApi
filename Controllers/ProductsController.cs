using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMySecondApi.Controllers
{

    //<summary>
    //{Controller}/{Action}/{Id?}
    //<summary>

    [Route("api/Products")]
    public class ProductsController: ControllerBase
    {
        //<summary>
        //Get: Products/Home
        //</summary>

        [HttpGet]
        public string Home() => "Hello World";
    }
}