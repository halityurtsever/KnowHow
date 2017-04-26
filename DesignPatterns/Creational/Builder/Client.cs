
namespace DesignPatterns.Creational.Builder
{
    internal class Client
    {
        internal void PlanVacation()
        {
            VacationPlanner vacationPlanner = new VacationPlanner();
            IBuilder vacationBuilder = vacationPlanner.GetVacationBuilder();

            VacationDay firstDay = vacationBuilder.AddHotel("Crown Plaza")
                                                  .AddDinnerReservation("Plaza Restaurant")
                                                  .AddSpecialEvent("Concert")
                                                  .AddTicket("Movie Ticket")
                                                  .BuildDay();

            vacationPlanner.AddVacationDay(firstDay);
        }
    }
}
