namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var livingRoomLight = new Light();

            ICommand lightOnCommand = new LightOnCommand(livingRoomLight);
            ICommand lightOffCommand = new LightOffCommand(livingRoomLight);

            RemoteControl remote = new RemoteControl();

            
            remote.SetCommand(lightOnCommand);
            remote.PressButton();

            // Turn the light off
            remote.SetCommand(lightOffCommand);
            remote.PressButton();

            // Undo the last operation (turn the light on again)
            remote.PressUndo();
        }
    }
}
