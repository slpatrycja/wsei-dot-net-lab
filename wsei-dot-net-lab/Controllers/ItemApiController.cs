using Microsoft.AspNetCore.Mvc;
using wsei_dot_net_lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using wsei_dot_net_lab.Database;
using wsei_dot_net_lab.Entities;

namespace wsei_dot_net_lab.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class ItemApiController : ControllerBase
    {
        private readonly ExchangesDbContext _dbContext;
        
        public ItemApiController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        [HttpPost]
        public IEnumerable<ItemEntity> Post([FromBody] JsonElement itemJson)
        {
            var data = JObject.Parse(itemJson.ToString());
            var entity = new ItemEntity
            {
                Name = (string) data["name"],
                Description = (string) data["description"],
                IsVisible = (string) data["isVisible"] == ""
            };
            
            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();

            return _dbContext.Items.ToList();
        }
    }
}