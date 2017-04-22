
namespace DesignPatterns.Creational.Builder.FirstImplementation
{
    internal static class VehicleConstructor
    {
        internal static void Construct(VehicleBuilder builder)
        {
            builder.BuildBrand();
            builder.BuildEngine();
            builder.BuildWheels();
            builder.BuildDoors();
        }
    }
}
