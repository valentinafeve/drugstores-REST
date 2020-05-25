using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using drugstoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace drugstoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            using (var context = new DotNetContext() )
            {
              // Get all the products from the database.
              return context.Product.ToList();
            }
        }
    }
}
