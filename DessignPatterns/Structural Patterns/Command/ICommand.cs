namespace DessignPatterns.Structural_Patterns.Command
{
    public interface ICommand
    {
        void Call();
        void Undo();
    }
}
