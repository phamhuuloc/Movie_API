using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using MOVIE_API.Services;
using Org.BouncyCastle.Asn1.Iana;

namespace MOVIE_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController: ControllerBase {
       private readonly ICustomerServices services;
       public CustomerController(ICustomerServices services) {
        this.services = services;
       }
       [HttpGet]
       public async Task<IActionResult> Get() {
             var data =  this.services.getAllCustomer();
             return Ok(data);
       }
       
    }
}