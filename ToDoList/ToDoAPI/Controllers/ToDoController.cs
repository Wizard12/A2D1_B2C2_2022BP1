using Microsoft.AspNetCore.Mvc;
using ToDoListModel.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        // GET: api/<ToDoController>
        [HttpGet]
        public IEnumerable<ToDoTask> Get()
        {
            return ToDoTask.ReadAll();
        }

        // GET api/<ToDoController>/5
        [HttpGet("{id}")]
        public ToDoTask Get(int id)
        {
            return ToDoTask.Read(id);
        }

        // POST api/<ToDoController>
        [HttpPost]
        public void Post([FromBody] string description)
        {
            ToDoTask newTask = new ToDoTask(description);
            newTask.Create();
        }

        // PUT api/<ToDoController>/5
        [HttpPut("{idToFinish}")]
        public void Put(int idToFinish)
        {
            ToDoTask finishtask = ToDoTask.Read(idToFinish);
            finishtask.FinishTask();
        }

        // DELETE api/<ToDoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ToDoTask deleteTask = ToDoTask.Read(id);
            deleteTask.Delete();
        }
    }
}
