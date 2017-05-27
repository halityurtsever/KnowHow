
namespace DesignPatterns.Behavioral.Command.Commands
{
    /// <summary>
    /// Command Interface
    /// </summary>
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
