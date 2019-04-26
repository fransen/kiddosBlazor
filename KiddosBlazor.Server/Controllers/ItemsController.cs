using KiddosBlazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KiddosBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        [HttpGet("[action]/{aantal}/{skip}")]
        public List<Item> Items(int aantal, int skip)
        {
            return AllCachedItems();
        }

        [HttpGet("[action]/{id}")]
        public Item Item(int id)
        {
            var items = Helpers.JsonLoader.Load<List<Item>>("assets/kiddos.json");
            return items[id];
        }

        private List<Item> AllCachedItems()
        {
            var items = Helpers.JsonLoader.Load<List<Item>>("assets/kiddos.json");
            return items;
        }
    }
}
