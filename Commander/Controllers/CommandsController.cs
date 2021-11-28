using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    //api/commands
    [Route("api/commands")] // how Api will handle exchanges 
    [ApiController]
    public class CommandsController : ControllerBase
    {

        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        // GET api/commands
        [HttpGet]
         public ActionResult <IEnumerable<Command>> GetAllCommands()
        {

            var commandItems = _repository.GetAppComands();
            return  Ok(commandItems);
        }


        // GET api/commands/5

        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.getCommandById(id);
            return Ok(commandItem);
        }
        
    }
}
