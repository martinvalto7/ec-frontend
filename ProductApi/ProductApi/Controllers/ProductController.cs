using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        public ActionResult GetProductList() 
        {
            ProductsContext context = new ProductsContext();
            List< Product> products  = context.Product.ToList();



            return Ok(products);
        }
    }
}