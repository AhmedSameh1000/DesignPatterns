namespace CommandPattern.Commands
{
    public class CommandInvoker
    {
        private List<ICommand> _commands = new();

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExicuteCommand()
        {
            foreach (var Command in _commands)
            {
                Command.Execute();
            }
        }
    }
}