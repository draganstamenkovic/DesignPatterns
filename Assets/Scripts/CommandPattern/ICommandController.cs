namespace DesignPatterns.Command
{
    public interface ICommandController
    {
        void Left();
        void Right();
        void Up();
        void Down();
        void Undo();
    }
}