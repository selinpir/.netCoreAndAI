using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreAiProject1.Context;
using NetCoreAiProject1.Entities;

namespace NetCoreAiProject1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        //dependency injection
        private readonly ApiContext _context;
        public CustomersController(ApiContext context)
        { _context = context; }
        //di--> program.cs bildirilecek == builder.Services.AddDbContext<ApiContext>();


        [HttpGet]
        //butun musteriler getirilir
        public IActionResult CustomerList()
        {
            var value=_context.Customers.ToList();
            return Ok(value);
        }

        //musteri ekleme
        [HttpPost]
        public IActionResult CrateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return Ok("müşteri ekleme işlemi başarılı oldu");
        }

        //musteri silme
        [HttpDelete]
        public IActionResult DeleteCustomer(int id) 
        {
            var value = _context.Customers.Find(id);
            _context.Customers.Remove(value);
            _context.SaveChanges();
            return Ok("müşteri silme işlemi başarılı oldu");
        }

        [HttpGet("GetCustomer")]
        public IActionResult GetCustomer(int id)
        {
            var value=_context.Customers.Find(id);
            return Ok(value);
        }

        //Guncelleme
        [HttpPut]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return Ok("müşteri güncelleme işlemi başarılı oldu");
        }
    }
}
