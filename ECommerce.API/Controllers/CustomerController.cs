using AutoMapper;
using ECommerce.Database;
using ECommerce.Services;
using ECommerce.Utilities;
using LMS.Database.ContextNamespace;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;
        public CustomerController(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }
        [HttpPost("Create")]
        public IActionResult Create([FromForm]UserInformationDTO UserInformationDTO)
        {            
            UserInformation UserInformation = _mapper.Map<UserInformation>(UserInformationDTO);
            _dataContext.UserInformations.Add(UserInformation);
            _dataContext.SaveChanges();
            Customer customer = new Customer{CustomerID = UserInformation.ID};
            _dataContext.Customers.Add(customer);
            _dataContext.SaveChanges();
            return Ok(_dataContext.UserInformations.Where(i => i.ID == UserInformation.ID).First());
        }
        [HttpGet("Get")]
        public IActionResult Get(int ID)
        {
            return Ok(_dataContext.Customers.Where(i => i.ID == ID).First());
        }
    }
}
