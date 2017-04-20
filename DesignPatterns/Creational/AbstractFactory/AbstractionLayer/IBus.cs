
namespace DesignPatterns.Creational.AbstractFactory.AbstractionLayer
{
    public interface IBus
    {
        int GetSeatCount { get; }

        bool IsSchoolBus();
    }
}
