namespace dotNet_Automation_course.Commands
{
    public class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            this._command = command;
        }

        public double ExecuteCommand()
        {
            return _command.Execute();
        }
    }
}
