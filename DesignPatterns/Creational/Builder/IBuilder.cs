
namespace DesignPatterns.Creational.Builder
{
    public interface IBuilder
    {
        VacationDay BuildDay();

        IBuilder AddHotel(string hotel);

        IBuilder AddDinnerReservation(string reservation);

        IBuilder AddSpecialEvent(string specialEvent);

        IBuilder AddTicket(string ticket);
    }
}
