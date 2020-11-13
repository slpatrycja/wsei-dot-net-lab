using Microsoft.AspNetCore.Mvc;
using wsei_dot_net_lab.Models;
using System;

namespace wsei_dot_net_lab.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class ItemApiController : ControllerBase
    {
        public AddNewItemResponse Post()
        {   
            Random rng = new Random();
            bool randomBool = rng.Next(0, 2) > 0;
            
            AddNewItemResponse result = new AddNewItemResponse
            {
                IsSuccessful = randomBool
            };

            return result;
        }
    }
}