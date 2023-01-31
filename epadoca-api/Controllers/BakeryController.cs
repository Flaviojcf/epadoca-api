using epadoca_api.Model;
using epadoca_api.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epadoca_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BakeryController : ControllerBase
    {
        private readonly BakeryRepository _bakeryRepository;

        public BakeryController()
        {
            _bakeryRepository = new BakeryRepository();
        }

        [HttpGet]
        public List <BakeryModel> GetAll() 
        {
           return _bakeryRepository.GetAll();
        }
    }
}
