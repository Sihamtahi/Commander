using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
            IEnumerable<Command> GetAppComands();
            Command getCommandById(int id);

    }
}
