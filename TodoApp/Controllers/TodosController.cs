using Microsoft.AspNetCore.Mvc;
using TodoApp.Entities;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private static List<TodoItem> _todoItems = new List<TodoItem>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_todoItems);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _todoItems.FirstOrDefault(x => x.TodoItemId == id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create(TodoItem newItem)
        {
            newItem.TodoItemId = _todoItems.Count + 1;
            _todoItems.Add(newItem);
            return CreatedAtAction(nameof(GetById), new { id = newItem.TodoItemId}, newItem);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, TodoItem updateItem)
        {
            var item = _todoItems.FirstOrDefault(x => x.TodoItemId == id);
            if (item == null)
            {
                return NotFound(); 
            }

            item.Title = updateItem.Title;
            item.Description = updateItem.Description;

            return NoContent(); 
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _todoItems.FirstOrDefault(x => x.TodoItemId == id);
            if (item == null)
                return NotFound();

            _todoItems.Remove(item);
            return NoContent();
        }

        [HttpPut("{id}/complete")]
        public IActionResult ToggleCompletion(int id)
        {
            var item = _todoItems.FirstOrDefault(x => x.TodoItemId == id);
            if (item == null)
                return NotFound();

            item.IsCompleted = !item.IsCompleted;

            return NoContent();
        }

    }
}
