using AutoMapper;
using DDDSkeleton.API.ViewModels;
using DDDSkeleton.Application.Interface;
using DDDSkeleton.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDDSkeleton.API.Controllers
{
    [Produces("application/json")]
    [Route("api/item")]
    public class ItemController : Controller
    {
        private readonly IItemAppService _itemApp;

        public ItemController(IItemAppService itemApp)
        {
            _itemApp = itemApp;
        }

        // GET: api/Item
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var items = await _itemApp.GetAll();
            var itemViewModel = Mapper.Map<IEnumerable<Item>, IEnumerable<ItemViewModel>>(items);
            return new JsonResult(itemViewModel);
        }

        // GET: api/Item/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Item
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Item/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
