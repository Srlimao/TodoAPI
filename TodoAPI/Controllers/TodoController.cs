using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace TodoAPI.Controllers
{
    public class TodoStruct
    {
        public string Title { get; set; }
        public DateTime DueDate{ get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        // GET: api/Todo
        [HttpGet]
        public string Get()
        {
            return JsonSerializer.Serialize(TodosManager.ListItems());
        }

        // POST: api/Todo
        [HttpPost]
        public void Post([FromBody] TodoStruct item)
        {
            TodosManager.AddItem(item.Title,item.DueDate);
        }

        [HttpPatch]
        public void SetCheck([FromQuery] string title,bool check)
        {
            TodosManager.SetCheckItem(title, check);
        }

        [HttpDelete]
        public void Remove([FromQuery] string title)
        {
            TodosManager.RemoveItem(title);
        }

    }
}
