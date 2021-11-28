using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppComands()
        {
            var commands = new List<Command>();

            Command c = new Command();
            c.HowTo = "Boil an egg";
            c.Line = "Boil water";
            c.Platform = "Kettle and Pan";
            c.Id = 0;
            commands.Add(c);
            Command c1 = new Command();
            c1.HowTo = "Drink war";
            c1.Line = "take as cupe";
            c1.Platform = "ghekk";
            c1.Id = 1;
            commands.Add(c1);
            Command c2 = new Command();
            c2.HowTo = "draw a portery";
            c2.Line = "take your pensil";
            c2.Platform = "loool";
            c2.Id = 2;
            commands.Add(c2);
            return commands;

        }

       public Command  getCommandById(int id)
        {  Command c = new Command();
            c.HowTo = "Boil an egg";
            c.Line = "Boil water";
            c.Platform = "Kettle and Pan";
            c.Id = 0; 
            return c;
        }
    }
}
